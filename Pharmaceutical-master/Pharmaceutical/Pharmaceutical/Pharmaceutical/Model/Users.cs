using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmaceutical.Model
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        [MaxLength(255), Unique]
        public string Username { get; set; }
        [MaxLength(255)]
        public string Password { get; set; }
        [MaxLength(255)]
        public string Role { get; set; }           
    }
}
