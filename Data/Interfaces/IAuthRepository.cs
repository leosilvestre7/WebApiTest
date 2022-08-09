using System;
using WebApiTest.Models;

namespace WebApiTest.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string email, string password);
        Task<bool> UserExist(string email);
    }
}
