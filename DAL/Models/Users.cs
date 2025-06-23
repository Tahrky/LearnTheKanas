using System;
using System.Collections.Generic;

namespace ApprentissageKana.DAL.Models
{
    public class Users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime creationAccountDate { get; set; }
        public DateTime lastConnectionDate { get; set; }
    }
}
