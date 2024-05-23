using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Account
{
    public class SaveAccountReq
    {
        public string mail { get; set; } = "";
        public string buName { get; set; } = "";
        public string account { get; set; } = "";
        public string password { get; set; } = "";
    }
}
