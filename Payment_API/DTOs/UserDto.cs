namespace Payment_API.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string UniqueIdentifierUid { get; set; }
    }
}
