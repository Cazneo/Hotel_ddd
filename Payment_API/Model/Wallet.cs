using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Payment_API.Model
{
    public class Wallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WalletID { get; set; }
        public int UserID { get; set; }
        public int DeviseID { get; set; }
        public float Montant { get; set; }
    }

}
