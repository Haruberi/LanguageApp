using System;
using System.Collections.Generic;
using System.Text;

namespace MyLangApp.Tables
{
    //Kopplat till UserRegisterPage
    public class RegUserTable
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
