using System;
using WebApiTest.Models;

namespace WebApiTest.Services.Interfaces
{
    public interface ItokenService
    {
        string CreateToken(User user);
        
    }
}
