using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    [Table("Controlli")]
    public class Controlli
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdControllo { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdPatient { get; set; }
        public DateTime DataControllo { get; set; }
        public string Valutazione { get; set; }
    }
}
