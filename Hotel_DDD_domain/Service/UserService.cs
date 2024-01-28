using AutoMapper;
using Hotel_DDD_domain.DTOs;
using Hotel_DDD_Domain.Repository;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDto> CreateUserAsync(string fullName, string emailAddress, string phoneNumber, string uniqueIdentifier)
    {
        bool emailExists = await _userRepository.DoesEmailExistAsync(emailAddress);
        if (emailExists)
        {
            throw new ApplicationException("The email address is already in use by another user.");
        }

        bool phoneNumberExists = await _userRepository.DoesPhoneNumberExistAsync(phoneNumber);
        if (phoneNumberExists)
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

        await _userRepository.CreateAsync(userDto);
        return userDto;
    }

    public async Task<UserDto> GetUserByIdAsync(int userId)
    {
        return await _userRepository.GetUserByIdAsync(userId);
    }

    public async Task<IList<UserDto>> GetUsersAsync()
    {
        var users = await _userRepository.GetAllUsersAsync();
        return users.ToList();
    }
}
