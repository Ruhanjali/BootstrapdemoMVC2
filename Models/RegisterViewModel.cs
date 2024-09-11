using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrapdemo.Models
{
   public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
        public string Gender { get; set; }
        public bool IsAgree { get; set; }   
    }

    public enum UserStatus
    {
        Active = 5,
        InActive = 3
    }
}