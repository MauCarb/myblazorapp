using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    [Table("Prescrizioni")]
    public class Prescrizione
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdPrescrizione { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdVisit { get; set; }
        public DateTime DataPrescrizione { get; set; }
        public DateTime PrintDate { get; set; }
        public decimal ptIdFarmaco { get; set; }
        public decimal ptIdFarmacoUso { get; set; }
        public string NotePrescr { get; set; }
    }
}
