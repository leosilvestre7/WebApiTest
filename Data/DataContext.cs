using System;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Models;
namespace WebApiTest.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<CourseResult> CourseResult { get; set; }

        public DbSet<User> User { get; set; }

    }
}
