using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared
{
    public class OphUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdUser { get; set; }
        public DateTime? InsertDate { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string usr { get; set; }
        public string pwd { get; set; }
        public DateTime? LastLogIn { get; set; }
        public DateTime? ExpireDate { get; set; }
        public Byte Status { get; set; }
        public Byte SuperAdmin { get; set; }
    }
}
