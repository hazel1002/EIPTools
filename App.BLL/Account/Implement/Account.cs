using App.Common;
using App.EF.EF.dbEIP;
using App.Model;
using App.Model.Account;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Account.Implement
{
    public class Account : ServiceBase, IAccount
    {
        public async Task<ResponseBase<SaveAccountRes>> CreateAccount(SaveAccountReq request, JWTPayload jWTPayload)
        {
            var response = new ResponseBase<SaveAccountRes>()
            {
                Entries = new SaveAccountRes()
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    if (string.IsNullOrEmpty(request.account))
                    {
                        response.Message = "未輸入帳號";
                        return response;
                    }
                    if (string.IsNullOrEmpty(request.mail))
                    {
                        response.Message = "未輸入信箱";
                        return response;
                    }

                    if (string.IsNullOrEmpty(request.buName))
                    {
                        response.Message = "未輸入BuName";
                        return response;
                    }

                    if (string.IsNullOrEmpty(request.password))
                    {
                        response.Message = "未輸入密碼";
                        return response;
                    }

                    // 建立Bu
                    int buid = await CreateBu(request.buName);
                    // bu可用語系
                    int isBulanguage = await CreateBuLanguage(buid);
                    // 功能與Bu對應
                    int isFunctionOnBu = CreateFunctionOnBu(buid);
                    // 建立角色
                    int userGroupId = await CreateUserGroup(buid);
                    // 建立角色與功能對應
                    int isFunctionOnGroup = await CreateFunctionOnGroup(userGroupId);
                    // 建立部門
                    int deptId = CreateDept(buid);
                    // 建立使用者
                    int userId = CreateUser(request.account,request.mail,request.password, buid, deptId);
                    // 使用者角色對應
                    int isUserOnGroup = await CreateUserOnGroup(userId,userGroupId);


                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.StatusCode = EnumStatusCode.Fail;
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private async Task<int> CreateBu(string buName)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    TblBusinessUnit bu = new TblBusinessUnit();
                    bu.CBucode = buName;
                    bu.CName = "平台端";
                    bu.CDescription = "管理員";
                    bu.CCreateDt = DateTime.UtcNow;
                    bu.CCreator = 1;
                    bu.CUpdateDt = DateTime.UtcNow;
                    bu.CUpdator = 1;
                    bu.CStatus = 1;
                    bu.CRemark = "管理員";
                    bu.CUserLimit = 9999;
                    bu.CPlatformIsSupport = true;
                    bu.CType = 1;
                    context.TblBusinessUnits.Add(bu);
                    await context.SaveChangesAsync();
                    response = bu.CId;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private async Task<int> CreateBuLanguage(int buid)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    List<TblBuLanguage> buLanguageList = new List<TblBuLanguage>();
                    //中文
                    TblBuLanguage buLanguage1 = new TblBuLanguage();
                    buLanguage1.CBuId = buid;
                    buLanguage1.CLanguageId = 1;
                    buLanguage1.CCreateDt = DateTime.UtcNow;
                    buLanguage1.CCreator = 1;
                    buLanguage1.CUpdatedDt = DateTime.UtcNow;
                    buLanguage1.CUpdator = 1;
                    buLanguage1.CIsDelete = false;
                    buLanguageList.Add(buLanguage1);
                    //英文
                    TblBuLanguage buLanguage2 = new TblBuLanguage();
                    buLanguage2.CBuId = buid;
                    buLanguage2.CLanguageId = 1;
                    buLanguage2.CCreateDt = DateTime.UtcNow;
                    buLanguage2.CCreator = 1;
                    buLanguage2.CUpdatedDt = DateTime.UtcNow;
                    buLanguage2.CUpdator = 1;
                    buLanguage2.CIsDelete = false;
                    buLanguageList.Add(buLanguage2);
                    context.TblBuLanguages.AddRange(buLanguageList);
                    await context.SaveChangesAsync();
                    response = 1;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private async Task<int> CreateUserGroup(int buid)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    TblUserGroup userGroup = new TblUserGroup();
                    userGroup.CName = "平台管理員";
                    userGroup.CStatus = 1;
                    userGroup.CUpdateDt = DateTime.UtcNow;
                    userGroup.CBuid = buid;
                    userGroup.CUpdator = 1;
                    userGroup.CCreateDt = DateTime.UtcNow;
                    userGroup.CCreator = 1;
                    context.TblUserGroups.Add(userGroup);
                    await context.SaveChangesAsync();
                    response = userGroup.CId;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private int CreateFunctionOnBu(int buid)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    var functions = context.TblFunctions
                            .Select(f => new TblFunctionOnBu()
                            {
                                CBuid = buid,
                                CFunctionId = f.CId,
                                CStatus = 1
                            }).ToList();
                    context.TblFunctionOnBus.AddRange(functions);
                    context.SaveChanges();
                    response = 1;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private async Task<int> CreateFunctionOnGroup(int userGroupId)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    var functionOnGroups = context.TblFunctions
                            .Select(f => new TblFunctionOnGroup
                            {
                                CUserGroupId = userGroupId,
                                CFunctionId = f.CId
                            }).ToList();

                    context.TblFunctionOnGroups.AddRange(functionOnGroups);
                    await context.SaveChangesAsync();
                    response = 1;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private int CreateDept(int buid)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    TblDept dept = new TblDept();
                    dept.CBuId = buid;
                    dept.CDeptCode = "D00000";
                    dept.CDeptName = "預設部門";
                    dept.CParentDeptId = 0;
                    dept.CCreateDt = DateTime.UtcNow;
                    dept.CCreator = 1;
                    dept.CUpdatedDt = DateTime.UtcNow;
                    dept.CUpdator = 1;
                    dept.CIsDelete = false;
                    dept.CDeptLevel = 0;

                    context.TblDepts.AddRange(dept);
                    context.SaveChanges();
                    response = dept.CDeptId;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private int CreateUser(string account, string mail, string password, int buid, int deptid)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    string salt = Common.AppSettingHelper.GetSection("HashedPasswordKey").Value;
                    if (string.IsNullOrEmpty(salt))
                        salt = "";
                    var hashPwd = Common.PBKDF2Helper.GetHashedPassword(password, salt);
                    TblUser user = new TblUser();
                    user.CUserName = account;
                    user.CAccount = account;
                    user.CPassword = hashPwd;
                    user.CMail = mail;
                    user.CIsDelete = false;
                    user.CCreator = 1;
                    user.CCreateDt = DateTime.UtcNow;
                    user.CUpdator = 1;
                    user.CUpdateDt = DateTime.UtcNow;
                    user.CStatus = 1;
                    user.CBuId = buid;
                    user.CLanguageId = 1;
                    user.CDeptId = deptid;
                    user.CIsChangePassword = true;
                    user.CIsFront = false;
                    user.CAdminStatus = 1;

                    context.TblUsers.AddRange(user);
                    context.SaveChanges();
                    response = user.CUserId;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }

        private async Task<int> CreateUserOnGroup(int userId, int userGroupId)
        {
            var response = 0;

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    TblUserOnGroup userOnGroup = new TblUserOnGroup();
                    userOnGroup.CUserId = userId;
                    userOnGroup.CUserGroupId = userGroupId;
                    userOnGroup.CStatus = true;

                    context.TblUserOnGroups.AddRange(userOnGroup);
                    await context.SaveChangesAsync();
                    response = 1;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("SearchIp EX Utc Now:{0}\n EX:{1}", DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss"), ex.ToString()));
            }

            return response;
        }


    }
}
