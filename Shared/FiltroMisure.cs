using System;

namespace BlazorApp.Shared
{
    public class FiltroMisure
    {
        public decimal IdPatient { get; set; }
        public decimal IdMisura { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CodFisc { get; set; }
        public string Mobile { get; set; }
        public DateTime? UltimaData { get; set; }
    }
}
