using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Data;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Data
{
    public class AppDbContext : DbContext                   //DbContext describe  Database Connection Bridge
    {
        public AppDbContext(                             //For now think: Configuration information comes here.We'll understand DI later.
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }             //db set describe tabe exist the model define the table 
    }
}

//Inheritance
//: DbContext
//Means:
//AppDbContext IS A DbContext                 ,Gets all EF Core functionality