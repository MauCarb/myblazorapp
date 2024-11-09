using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared
{
    [Table("Ortottica")]
    public class Ortottica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdOrtottica { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdPatient { get; set; }
        public DateTime DataOrtottica { get; set; }
        public String Posizione { get; set; }
        public String Motilita { get; set; }
        public String Convergenza { get; set; }
        public String Cover { get; set; }
        public String PrismaCover { get; set; }
        public String Ampiezza { get; set; }
        public String Vetro { get; set; }
        public String Lang { get; set; }
        public String Titmus { get; set; }
        public String AltriTest { get; set; }
        public String Conclusioni { get; set; }
        public String Diagnosi { get; set; }
        public String Terapia { get; set; }
    }
}
