using Hotel_DDD_domain.Model;

namespace Hotel_DDD_Domain.Repository
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
        bool DoesEmailExist(string emailAddress);
        bool DoesPhoneNumberExist(string phoneNumber);
        void Create(User user);
        void Update(User user);
        void Delete(User user);
    }
}