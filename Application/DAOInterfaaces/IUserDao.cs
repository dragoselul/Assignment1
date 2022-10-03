using Domain.Models;

namespace Application.DAOInterfaaces;

public interface IUserDao
{
    Task<User> RegisterAsync(User user);
    Task<User?> GetByUsernameAsync(string userName);
}