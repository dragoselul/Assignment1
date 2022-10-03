namespace Domain.DTOs;

public class UserRegistrationDto
{
    public string UserName { get; }
    public string Password { get; }

    public UserRegistrationDto(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
}