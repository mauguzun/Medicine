using DataAccess.Interfaces;
using Medicine.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Sql
{
    public class DbContextReadOnly : DbContext, IDbContextReadonly
    {
        public DbContextReadOnly(DbContextOptions<DbContextReadOnly> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Therapy> Therapies { get; set; }
    }
}