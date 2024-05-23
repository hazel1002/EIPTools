using App.Model;
using App.Model.Account;
using App.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Account
{
    public interface IAccount
    {
        Task<ResponseBase<SaveAccountRes>> CreateAccount(SaveAccountReq request, JWTPayload jWTPayload);
    }
}
