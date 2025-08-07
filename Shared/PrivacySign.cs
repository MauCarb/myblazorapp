using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared
{
    [Table("PrivacySign")]
    public class PrivacySign
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal IdSign { get; set; }
        public decimal ptIdPatient { get; set; }
        public string SignGuid { get; set; }
    }
}
