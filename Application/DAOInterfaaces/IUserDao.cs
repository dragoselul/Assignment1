using Domain.DTOs;
using Domain.Models;

namespace Application.DAOInterfaaces;

public interface IUserDao
{
    Task<User> RegisterAsync(User user);
    Task<User?> GetByUsernameAsync(string userName);
    Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
    Task<User?> GetByIdAsync(int id);

}