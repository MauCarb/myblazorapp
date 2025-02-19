using System;

namespace BlazorApp.Shared
{
    public class Prescrizioni
    {
        public decimal IdPrescrizione { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdVisit { get; set; }
        public DateTime DataPrescrizione { get; set; }
        public DateTime PrintDate { get; set; }
        public decimal ptIdFarmaco { get; set; }
        public decimal ptIdFarmacoUso { get; set; }
        public string Farmaco { get; set; }
        public string Uso { get; set; }
        public string UsoOrig { get; set; }
        public string NotePrescr { get; set; }
        public int Action { get; set; }
    }
}
