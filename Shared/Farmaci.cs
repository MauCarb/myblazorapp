using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    [Table("Farmaci")]
    public class Farmaci
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdFarmaco { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public string Farmaco { get; set; }
        public int Stato { get; set; }
    }
}