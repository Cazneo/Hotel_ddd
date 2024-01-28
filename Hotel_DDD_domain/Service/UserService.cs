using AutoMapper;
using Hotel_DDD_Domain.Repository;
using Hotel_DDD_domain.DTOs;


namespace Hotel_DDD_domain.Service
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public UserDto CreateUser(string fullName, string emailAddress, string phoneNumber, string uniqueIdentifier)
        {
            if (_userRepository.DoesEmailExist(emailAddress))
            {
                throw new ApplicationException("The email address is already in use by another user.");
            }

            if (_userRepository.DoesPhoneNumberExist(phoneNumber))
            {
                throw new ApplicationException("The phone number is already in use by another user.");
            }

            var userDto = new UserDto
            {
                FullName = fullName,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
                UniqueIdentifier = uniqueIdentifier
            };

            _userRepository.Create(userDto);

            return userDto;
        }

        public UserDto GetUserById(int userId)
        {
            var userDto = _userRepository.GetUserById(userId);
            return userDto;
        }

        public IList<UserDto> GetUsers()
        {
            var userDtos = _userRepository.GetAllUsers();
            return userDtos.ToList();
        }
    }
}