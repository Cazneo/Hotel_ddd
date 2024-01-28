namespace Payment_API.DTOs
{
    public class WalletDto
    {
        public int WalletID { get; set; }
        public int UserID { get; set; }
        public UserDto User { get; set; }
        public int DeviseID { get; set; }
        public DeviseDto Devise { get; set; }
        public float Montant { get; set; }

    }
}
