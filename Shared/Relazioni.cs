using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    [Table("Relazioni")]
    public class Relazioni
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdRelazione { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdVisit { get; set; }
        public DateTime DataRelazione { get; set; }
        public DateTime PrintDate { get; set; }
        public string DiagnosiOD { get; set; }
        public string DiagnosiOS { get; set; }
        public string SHIRMER_Od { get; set; }
        public string SHIRMER_Os { get; set; }
        public string Seg_Ant_Od { get; set; }
        public string Seg_Ant_Os { get; set; }
        public string Visus_Od { get; set; }
        public string Visus_Os { get; set; }
        public string TONO_Od { get; set; }
        public string TONO_Os { get; set; }
        public string Fundus_Od { get; set; }
        public string Fundus_Os { get; set; }
    }
}
