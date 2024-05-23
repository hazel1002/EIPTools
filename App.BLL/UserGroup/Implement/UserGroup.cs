using App.EF.EF.dbEIP;
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
using App.Enum;

namespace App.BLL
{
    public class UserGroup : ServiceBase, IUserGroup
    {
        public async Task<ResponseBase<List<UserGroupGetListResponse>>> GetList(UserGroupGetListArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<List<UserGroupGetListResponse>>()
            {
                Entries = new List<UserGroupGetListResponse>(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    //TODO 補權限
                    var TblUsersGroup = context.TblUserGroups.Where(x => x.CBuid == jwtPayload.BuId).Select(x => new UserGroupGetListResponse
                    {
                        CBuid = x.CBuid,
                        CId = x.CId,
                        CName = x.CName,
                        CStatus = x.CStatus,
                        CUpdateDt = x.CUpdateDt
                    });

                    if (Args.CStatus != -1)
                    {
                        TblUsersGroup = TblUsersGroup.Where(x => x.CStatus == Args.CStatus);
                    }

                    if (!string.IsNullOrEmpty(Args.CName))
                    {
                        TblUsersGroup = TblUsersGroup.Where(x => x.CName.Contains(Args.CName));
                    }


                    response.TotalItems = TblUsersGroup.Count();
                    response.Entries = TblUsersGroup.Skip((Args.PageIndex - 1) * Args.PageSize).Take(Args.PageSize).ToList();
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
        public async Task<ResponseBase<UserGroupGetDataResponse>> GetData(UserGroupGetDataArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserGroupGetDataResponse>()
            {
                Entries = new UserGroupGetDataResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    //群組名稱
                    var UserGroup = context.TblUserGroups.Where(x => x.CId == Args.CId).FirstOrDefault();

                    //群組權限+是否有選擇
                    var Functions = (from functionOnBU in context.TblFunctionOnBus
                                     join function in context.TblFunctions on functionOnBU.CFunctionId equals function.CId
                                     join functionOnGroup in context.TblFunctionOnGroups
                                           on new { CFunctionId = function.CId, CUserGroupId = (Args.CId ?? 0) }
                                       equals new { CFunctionId = functionOnGroup.CFunctionId, CUserGroupId = functionOnGroup.CUserGroupId } into ps
                                     from functionOnGroup in ps.DefaultIfEmpty()
                                     where functionOnBU.CBuid == jwtPayload.BuId
                                     orderby function.CMenuIndex
                                     select new
                                     {
                                         function.CId,
                                         function.CName,
                                         function.CParentId,
                                         function.CIsMenu,
                                         function.CMenuIndex,
                                         function.CCompetenceType,
                                         IsChecked = functionOnGroup != null,
                                     }).ToList();

                    //功能列舉
                    var ListCompetenceType = EnumHelper.GetEnumList<CompetenceType>();

                    response.Entries = new UserGroupGetDataResponse()
                    {
                        CId = UserGroup?.CId,
                        CName = UserGroup?.CName ?? "",
                        FunctionLv1 = (from functionLv1 in Functions
                                       where functionLv1.CParentId == 0
                                       orderby functionLv1.CMenuIndex
                                       select new UserGroupGetDataFunctionLv1
                                       {
                                           CId = functionLv1.CId,
                                           CName = functionLv1.CName,
                                           FunctionLv2 = (from functionLv2 in Functions
                                                          where functionLv2.CParentId == functionLv1.CId
                                                          orderby functionLv2.CMenuIndex
                                                          select new UserGroupGetDataFunctionLv2
                                                          {
                                                              CId = functionLv2.CId,
                                                              CName = functionLv2.CName,
                                                              Authority = (from authority in Functions
                                                                           join listCompetenceType in ListCompetenceType on authority.CCompetenceType equals (byte?)listCompetenceType.Key
                                                                           where authority.CParentId == functionLv2.CId
                                                                           orderby authority.CMenuIndex
                                                                           select new UserGroupGetDataAuthority
                                                                           {
                                                                               CId = authority.CId,
                                                                               CName = listCompetenceType.Value,
                                                                               IsChecked = authority.IsChecked,
                                                                           }).ToList()
                                                          }).ToList()
                                       }).ToList()
                    };
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

        public async Task<ResponseBase<UserGroupSaveDataResponse>> SaveData(UserGroupSaveDataArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserGroupSaveDataResponse>()
            {
                Entries = new UserGroupSaveDataResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Slave))
                {
                    //新增編輯群組主檔
                    var IsAdd = true;
                    TblUserGroup TblUsersGroup = new TblUserGroup();
                    if (Args.CId != null)
                    {
                        IsAdd = false;
                        TblUsersGroup = await context.TblUserGroups.Where(x => x.CBuid == jwtPayload.BuId && x.CId == (int)Args.CId).FirstOrDefaultAsync();// context.TblUsersGroup.Find((int)Args.CId);
                        if (TblUsersGroup == null)
                        {
                            TblUsersGroup = new TblUserGroup();
                            IsAdd = true;
                        }
                    }

                    TblUsersGroup.CName = Args.CName;
                    TblUsersGroup.CStatus = (int)Status.Enable;
                    TblUsersGroup.CBuid = jwtPayload.BuId;

                    if (IsAdd)
                    {
                        context.TblUserGroups.Add(TblUsersGroup);
                    }

                    context.SaveChanges();

                    //新增編輯權限

                    //先刪
                    context.TblFunctionOnGroups.RemoveRange(context.TblFunctionOnGroups.Where(x => x.CUserGroupId == TblUsersGroup.CId));

                    List<TblFunctionOnGroup> ListFunctionOnGroup = new List<TblFunctionOnGroup>();

                    //lv1
                    ListFunctionOnGroup.AddRange(
                        Args.FunctionLv1.Select(x => new TblFunctionOnGroup
                        {
                            CUserGroupId = TblUsersGroup.CId,
                            CFunctionId = x.CId
                        }).ToList()
                    );

                    //lv2
                    ListFunctionOnGroup.AddRange(
                        Args.FunctionLv1.SelectMany(x => x.FunctionLv2).Select(x => new TblFunctionOnGroup
                        {
                            CUserGroupId = TblUsersGroup.CId,
                            CFunctionId = x.CId
                        }).ToList()
                    );

                    //lv3
                    ListFunctionOnGroup.AddRange(
                        Args.FunctionLv1.SelectMany(x => x.FunctionLv2).SelectMany(x => x.Authority).Where(x => x.IsChecked).Select(x => new TblFunctionOnGroup
                        {
                            CUserGroupId = TblUsersGroup.CId,
                            CFunctionId = x.CId
                        }).ToList()
                    );

                    context.TblFunctionOnGroups.AddRange(ListFunctionOnGroup.OrderBy(x => x.CUserGroupId));
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

        public async Task<ResponseBase<UserGroupRemoveDataResponse>> RemoveData(UserGroupRemoveDataArgs Args, JWTPayload jwtPayload)
        {
            var response = new ResponseBase<UserGroupRemoveDataResponse>()
            {
                Entries = new UserGroupRemoveDataResponse(),
            };

            try
            {
                using (var context = base.dbTemplate(Enum.ConnectionMode.Master))
                {
                    var TblUsersGroup = await context.TblUserGroups.Where(x => x.CBuid == jwtPayload.BuId && x.CId == (int)Args.CId).FirstOrDefaultAsync();// context.TblUsersGroup.Find((int)Args.CId);
                    if (TblUsersGroup != null)
                    {
                        context.TblUserGroups.Remove(TblUsersGroup);

                        context.TblFunctionOnGroups.RemoveRange(context.TblFunctionOnGroups.Where(x => x.CUserGroupId == Args.CId));

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


    }
}
