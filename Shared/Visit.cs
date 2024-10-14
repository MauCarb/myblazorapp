using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared
{
    [Table("Visits")]
    public class Visit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdVisit { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdPatient { get; set; }
        public decimal ptIdAppointment { get; set; }
        public DateTime DataVisita { get; set; }
        public string Diagnosi { get; set; }
        public string Anamnesi { get; set; }
        public string Annessi { get; set; }
        public string Seg_Ant_Od { get; set; }
        public string Seg_Ant_Os { get; set; }
        public string Fundus_Od { get; set; }
        public string Fundus_Os { get; set; }
        public string Visus_Od { get; set; }
        public string Visus_Os { get; set; }
        public string Terapia { get; set; }
        public string ODPL { get; set; }
        public string ODPV { get; set; }
        public string ODMD { get; set; }
        public string OSPL { get; set; }
        public string OSPV { get; set; }
        public string OSMD { get; set; }
        public string Interventi { get; set; }
        public string CurvaTono { get; set; }
        public string CurvaArgon { get; set; }
        public string VOrtottica { get; set; }
        public string SHIRMER { get; set; }
        public string TONO { get; set; }
        public string Lavaggio { get; set; }
        public string Biometria { get; set; }
        public string FAG_Od { get; set; }
        public string FAG_Os { get; set; }
        public string Topografia { get; set; }
        public string IV { get; set; }
        public string OCT_Od { get; set; }
        public string OCT_Os { get; set; }
        public string RNFL_Od { get; set; }
        public string RNFL_Os { get; set; }
        public string CV_Od { get; set; }
        public string CV_Os { get; set; }
        public string PACH_Od { get; set; }
        public string PACH_Os { get; set; }
        public string CD_Od { get; set; }
        public string CD_Os { get; set; }
        public string Auto { get; set; }
        public string MotivoVisita { get; set; }
        public string Conclusioni { get; set; }
        public string Note { get; set; }
        public Byte TipoVisita { get; set; }
    }
}
