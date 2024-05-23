using App.BLL;
using App.BLL.Account;
using App.Enum;
using App.Model;
using App.Model.Account;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Globalization;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccount _account;

        public AccountController(IAccount account)
        {
            this._account = account;
        }

        /// <summary>
        /// 新增帳號
        /// </summary>
        [Route("CreateAccount")]
        [HttpPost]
        [AuthorizationFilter]
        public async Task<ResponseBase<SaveAccountRes>> CreateAccount([FromBody] SaveAccountReq request)
        {
            JWTPayload jwtPayload = (JWTPayload)HttpContext.Items["jwtPayload"];
            return await _account.CreateAccount(request, jwtPayload);
        }
    }
}
