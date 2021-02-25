using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLangApp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        [MaxLength(12)]
        public string Password { get; set; }
        [MaxLength(10)]
        public string Email { get; set; }
    }
}

