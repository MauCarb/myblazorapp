using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared
{
    [Table("Patients")]
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdPatient { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Cod { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CodFisc { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public Boolean fPrivacy { get; set; }
        public string Studio { get; set; }
    }
}
