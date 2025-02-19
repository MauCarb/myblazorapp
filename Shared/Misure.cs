using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    [Table("Misure")]
    public class Misure
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdMisura { get; set; }
        public decimal ptIdUser { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal ptIdVisit { get; set; }
        public decimal ptIdPatient { get; set; }
        public DateTime DataMisura { get; set; }
        public DateTime PrintDate { get; set; }
        public String ODD_Sf { get; set; }
        public String ODD_Cil { get; set; }
        public String ODD_Asse { get; set; }
        public String OSD_Sf { get; set; }
        public String OSD_Cil { get; set; }
        public String OSD_Asse { get; set; }
        public String ODP_Sf { get; set; }
        public String ODP_Cil { get; set; }
        public String ODP_Asse { get; set; }
        public String OSP_Sf { get; set; }
        public String OSP_Cil { get; set; }
        public String OSP_Asse { get; set; }
        public String ODL_Sf { get; set; }
        public String ODL_Cil { get; set; }
        public String ODL_Asse { get; set; }
        public String OSL_Sf { get; set; }
        public String OSL_Cil { get; set; }
        public String OSL_Asse { get; set; }
        public Boolean Tabo { get; set; }
        public Boolean Inter { get; set; }
        public String DI { get; set; }
        public String Note { get; set; }
    }
}
