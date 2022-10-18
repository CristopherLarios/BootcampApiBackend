using Microsoft.EntityFrameworkCore;
using TareaBootcamp.Model.DataModels;


namespace TareaBootcamp.DataAcces
{
    public class BootcampDBContext: DbContext
    {
        public BootcampDBContext(DbContextOptions<BootcampDBContext> options) : base(options) { 
        }

        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<User>? Users { get; set; }
    }
    
}
