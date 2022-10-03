using Application.DAOInterfaaces;
using Domain.DTOs;
using Domain.Exceptions;
using Domain.Models;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;

    public UserLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    public async Task<User> RegisterAsync(UserRegistrationDto userToRegister)
    {
        User? existing = await userDao.GetByUsernameAsync(userToRegister.UserName);
        if (existing != null)
            throw new UserException("There is already a user with this username", userToRegister.UserName);
        ValidateData(userToRegister);
        User toRegister = new User
        {
            UserName = userToRegister.UserName,
            Password = userToRegister.Password
        };
        User registered = await userDao.RegisterAsync(toRegister);
        return registered;
    }
    
    private static void ValidateData(UserRegistrationDto userToRegister)
    {
        string userName = userToRegister.UserName;
        string password = userToRegister.Password;

        if (userName.Length < 3)
            throw new UserException("Username must be at least 3 characters!",userName);

        if (userName.Length > 15)
            throw new UserException("Username must be less than 16 characters!",userName);
        if(password.Length <3)
            throw new UserException("Password must be at least 3 characters!");
        if (password.Length > 20)
            throw new UserException("Password must be less than 20 characters!");

    }
}