using System;
using WebApiTest.Data.Interfaces;
using WebApiTest.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiTest.Data
{
    public class ApiRepository : IApiRepository
    {
        private readonly DataContext _context;

        public ApiRepository(DataContext context) 
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<IEnumerable<CourseResult>> GetCourseResultsAsync()
        {
            return await _context.CourseResult.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.UserId == id);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
