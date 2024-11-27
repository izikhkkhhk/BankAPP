using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BankApp
{
    internal class LoginRequest
    {
        public string login { get; set; }
        public string password { get; set; }

        public LoginRequest(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    
}
