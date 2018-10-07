using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapchaTest.Models
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string  Password { get; set; }
        public string Code { get; set; }
        public string  WriteCode { get; set; }
    }
}