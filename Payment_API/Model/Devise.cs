using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Payment_API.Model
{

    public class Devise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeviseID { get; set; }
        public string? NomDevise { get; set; }
        public float? TauxConversionEuro { get; set; }


    }
}