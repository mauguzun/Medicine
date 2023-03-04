using Medicine.Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Interfaces
{
    public interface IDbContextReadonly
    {
         DbSet<Course> Courses { get; }
         DbSet<Therapy> Therapies { get; }
    }
}