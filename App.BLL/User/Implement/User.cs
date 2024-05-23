using App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jose;
using App.Common;
using Mapster;
using App.EF.EF.dbEIP;

namespace App.BLL
{
    public class User : ServiceBase, IUser
    {
        public Task<ResponseBase<TblUser>> GetUser(string model)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseBase<string>> UserLogin(UserLoginRequest model, string clientIP)
        {
            var response = new ResponseBase<string>();

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    string salt = Common.AppSettingHelper.GetSection("HashedPasswordKey").Value;
                    if (string.IsNullOrEmpty(salt))
                        salt = "";

                    var hashPwd = Common.PBKDF2Helper.GetHashedPassword(model.Password, salt);
                    var account = await context.TblUsers.Where(x => x.CAccount == model.Account).FirstOrDefaultAsync();
                    if (account != null && account.CPassword == hashPwd)
                    {
                        var secret = AppSettingHelper.GetSection("TokenSecret").Value; //加密字串

                        var payload = new JWTPayload()
                        {
                            BuId = (int)account.CBuId,
                            UserId = account.CUserId,
                            UserName = account.CUserName,
                            CreateTime = DateTime.UtcNow,
                            ExpTime = DateTime.UtcNow.AddMinutes(120)
                        };

                        string jwtToken = Jose.JWT.Encode(payload, Encoding.UTF8.GetBytes(secret), JwsAlgorithm.HS256);
                        response.Entries = jwtToken;

                        //Login Log
                        await SetLoginLog(new SetLoginLogArgs() { jwttToken = jwtToken, CIp = clientIP }, payload);

                        //Action Log
                        await SetUserLog(new UserSetUserLogArgs() { FunctionId = 1, Ip = clientIP }, payload);
                    }
                    else
                    {
                        response.Message = "登入失敗";
                        response.StatusCode = EnumStatusCode.Fail;
                    }
                }


            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        public async Task<ResponseBase<GetMenuResponse>> GetMenu(GetMenuArgs args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<GetMenuResponse>()
            {
                Entries = new GetMenuResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    //TODO 補權限
                    //var TblFunction = context.TblFunction.ToList();
                    var TblFunction = (from uong in context.TblUserOnGroups
                                       join fong in context.TblFunctionOnGroups on uong.CUserGroupId equals fong.CUserGroupId
                                       join f in context.TblFunctions on new { CFunctionId = fong.CFunctionId } equals new { CFunctionId = f.CId }
                                       where uong.CUserId == jwtPayload.UserId
                                       && uong.CStatus == true
                                       && f.CStatus == (int)Enum.Status.Enable
                                       select f).Distinct().ToList();

                    var Function = TblFunction.Adapt<List<FunctionDTO>>();


                    response.Entries.Menu = ChildMenu(Function, 0);
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        public List<FunctionDTO> ChildMenu(List<FunctionDTO> Args, int ParentId)
        {
            List<FunctionDTO> returnData = new List<FunctionDTO>();

            foreach (var item in Args.Where(x => x.CParentId == ParentId).OrderBy(x => x.CMenuIndex))
            {
                var dc = item;
                dc.Child = ChildMenu(Args, dc.CId);
                returnData.Add(dc);
            }
            return returnData;
        }

        public async Task<ResponseBase<List<UserGetListResponse>>> GetList(UserGetListArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<List<UserGetListResponse>>()
            {
                Entries = new List<UserGetListResponse>(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    //TODO 補權限
                    var User = (from user in context.TblUsers
                                where user.CBuId == jwtPayload.BuId
                                select new UserGetListResponse
                                {
                                    CAccount = user.CAccount,
                                    CName = user.CUserName,
                                    CStatus = (int)user.CStatus,
                                    CUserId = user.CUserId,
                                    CUserGroupName = string.Join(",", (from TblUsersOnGroup in context.TblUserOnGroups
                                                                       join TblUsersGroup in context.TblUserGroups on TblUsersOnGroup.CUserGroupId equals TblUsersGroup.CId
                                                                       where TblUsersOnGroup.CUserId == user.CUserId
                                                                       select TblUsersGroup.CName))
                                });

                    if (Args.CStatus != -1)
                    {
                        User = User.Where(x => x.CStatus == Args.CStatus);
                    }

                    if (!string.IsNullOrEmpty(Args.CUserName))
                    {
                        User = User.Where(x => x.CAccount.Contains(Args.CUserName) || x.CName.Contains(Args.CUserName));
                    }

                    response.TotalItems = User.Count();
                    response.Entries = User.Skip((Args.PageIndex - 1) * Args.PageSize).Take(Args.PageSize).ToList();
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        public async Task<ResponseBase<UserGetDataResponse>> GetData(UserGetDataArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserGetDataResponse>()
            {
                Entries = new UserGetDataResponse(),
            };

            try
            {
                if (Args.CUserId != null)
                {
                    using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                    {
                        var User = (from user in context.TblUsers
                                    where user.CUserId == Args.CUserId
                                    select new UserGetDataResponse
                                    {
                                        CAccount = user.CAccount,
                                        CName = user.CUserName,
                                        CStatus = (int)user.CStatus,
                                        CUserId = user.CUserId,
                                        ListUserGroup = context.TblUserOnGroups.Where(x => x.CUserId == user.CUserId).Select(x => x.CUserGroupId).ToList(),
                                    }).FirstOrDefault();
                        response.Entries = User;

                    }
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        public async Task<ResponseBase<UserSaveDataResponse>> SaveData(UserSaveDataArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserSaveDataResponse>()
            {
                Entries = new UserSaveDataResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    var IsAdd = false;
                    TblUser TblUsers = new TblUser();
                    string salt = Common.AppSettingHelper.GetSection("HashedPasswordKey").Value;
                    if (Args.CUserId == null)
                    {
                        //TODO 沒有by Buid
                        IsAdd = true;
                        //檢查帳號是重複
                        if (context.TblUsers.Where(x => x.CAccount == Args.CAccount).FirstOrDefault() != null)
                        {
                            response.StatusCode = EnumStatusCode.Fail;
                            response.Message = "帳號已被使用";
                            return response;
                        }

                        //檢查密碼 - 新增
                        if (string.IsNullOrEmpty(Args.Password) && Args.Password != Args.CfmPassword)
                        {
                            response.StatusCode = EnumStatusCode.Fail;
                            response.Message = "確認密碼不相同";
                            return response;
                        }

                        
                        TblUsers.CAccount = Args.CAccount;
                        TblUsers.CBuId = jwtPayload.BuId;
                        TblUsers.CPassword = Common.PBKDF2Helper.GetHashedPassword(Args.Password, salt);
                    }
                    else
                    {
                        TblUsers = await context.TblUsers.Where(x => x.CBuId == jwtPayload.BuId && x.CUserId == Args.CUserId).FirstOrDefaultAsync(); //context.TblUsers.Find(Args.CUserId);
                        if (TblUsers != null)
                        {
                            //修改密碼
                            if (!string.IsNullOrEmpty(Args.Password))
                            {
                                if (Args.Password != Args.CfmPassword)
                                {
                                    response.StatusCode = EnumStatusCode.Fail;
                                    response.Message = "確認密碼不相同";
                                    return response;
                                }
                                else if (Common.PBKDF2Helper.GetHashedPassword(Args.OldPassword, salt) != TblUsers.CPassword)
                                {
                                    response.StatusCode = EnumStatusCode.Fail;
                                    response.Message = "錯誤的舊密碼";
                                    return response;
                                }
                                TblUsers.CPassword = Common.PBKDF2Helper.GetHashedPassword(Args.Password, salt);
                            }
                        }
                        else
                        {
                            TblUsers = new TblUser();
                        }
                    }

                    TblUsers.CUserName = Args.CName;
                    TblUsers.CStatus = Args.CStatus;

                    if (IsAdd)
                    {
                        context.TblUsers.Add(TblUsers);
                    }

                    context.SaveChanges();

                    //群組
                    context.TblUserOnGroups.RemoveRange(context.TblUserOnGroups.Where(x => x.CUserId == TblUsers.CUserId));

                    context.TblUserOnGroups.AddRange(
                       Args.ListUserGroup.Select(x => new TblUserOnGroup
                       {
                           CUserId = TblUsers.CUserId,
                           CStatus = true,
                           CUserGroupId = x
                       })); ;
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        public async Task<ResponseBase<UserRemoveDataResponse>> RemoveData(UserRemoveDataArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserRemoveDataResponse>()
            {
                Entries = new UserRemoveDataResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    var user = context.TblUsers.Where(x => x.CBuId == jwtPayload.BuId && x.CUserId == Args.CUserId).FirstOrDefault();
                    if (user != null)
                    {
                        //context.TblUsers.Remove(context.TblUsers.Find(Args.CUserId));
                        context.TblUsers.Remove(user);

                        context.TblUserOnGroups.RemoveRange(context.TblUserOnGroups.Where(x => x.CUserId == Args.CUserId));

                        context.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }


        public async Task<ResponseBase<List<UserGetUserLogResponse>>> GetUserLog(UserGetUserLogArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<List<UserGetUserLogResponse>>()
            {
                Entries = new List<UserGetUserLogResponse>(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    var UtcNow = DateTime.UtcNow;
                    //TODO 補權限
                    var AccessLog = (from accessLog in context.TblAccessLogs
                                     join user in context.TblUsers on accessLog.CUserId equals user.CUserId
                                     join function in context.TblFunctions on accessLog.CFunctionId equals function.CId
                                     where accessLog.CCreateDt >= Args.DateStart && accessLog.CCreateDt < Args.DateEnd

                                     select new UserGetUserLogResponse
                                     {
                                         CId = accessLog.CId,
                                         CAccount = user.CAccount,
                                         CName = user.CUserName,
                                         DateCreate = (DateTime)accessLog.CCreateDt,
                                         FunctionId = function.CId,
                                         FunctionName = function.CName,
                                         Ip = accessLog.CIp
                                     });

                    if (Args.FunctionId != -1)
                    {
                        AccessLog = AccessLog.Where(x => x.FunctionId == Args.FunctionId);
                    }

                    response.TotalItems = AccessLog.Count();
                    response.Entries = AccessLog.Skip((Args.PageIndex - 1) * Args.PageSize).Take(Args.PageSize).ToList();

                }
            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        public async Task<ResponseBase<UserSetUserLogResponse>> SetUserLog(UserSetUserLogArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserSetUserLogResponse>()
            {
                Entries = new UserSetUserLogResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    var UtcNow = DateTime.UtcNow;
                    TblAccessLog tblAccessLog = new TblAccessLog()
                    {
                        CUserId = jwtPayload.UserId,
                        CFunctionId = Args.FunctionId,
                        CActionName = Args.ActionName,
                        CApiname = Args.APIName,
                        CRequest = Args.Request,
                        CUrl = Args.Url,
                        CRemark = Args.Remark,
                        CIp = Args.Ip,
                        CCreateDt = UtcNow,
                        CCreator = jwtPayload.UserId,
                        CUpdateDt = UtcNow,
                        CUpdator = jwtPayload.UserId,
                    };
                    context.TblAccessLogs.Add(tblAccessLog);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

        private async Task<ResponseBase<string>> SetLoginLog(SetLoginLogArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<string>()
            {
                Entries = "",
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    TblLoginLog tblLoginLog = new TblLoginLog()
                    {
                        CCreateDt = DateTime.UtcNow,
                        CCreator = jwtPayload.UserId,
                        CUpdateDt = DateTime.UtcNow,
                        CUpdator = jwtPayload.UserId,
                        CUserId = jwtPayload.UserId,
                        CUserToken = Args.jwttToken,
                        CIp = Args.CIp,
                    };

                    context.TblLoginLogs.Add(tblLoginLog);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = EnumStatusCode.Fail;
                response.Message = ex.Message;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }
            return response;
        }

    }
}
