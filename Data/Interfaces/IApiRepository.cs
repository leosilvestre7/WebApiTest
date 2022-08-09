using System;
using WebApiTest.Models;

namespace WebApiTest.Data.Interfaces
{
    public interface IApiRepository
    {
        void Add<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<CourseResult>> GetCourseResultsAsync();
        Task<IEnumerable<CourseResult>> GetCourseByUserIdAsync(int id);
    }
}
