using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    [Table("FarmaciUso")]
    public class FarmaciUso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdFarmacoUso { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdFarmaco { get; set; }
        public string Uso { get; set; }
    }
}
