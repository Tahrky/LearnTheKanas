using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApprentissageKana.DAL.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public string email { get; set; }
        public DateTime creationAccountDate { get; set; }
        public DateTime lastConnectionDate { get; set; }
        public Langue langue { get; set; }

        // Jointure vers d’autres tables
        public List<Stats> stats { get; set; }
    }
}
