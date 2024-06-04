using HTMLLesson.Helper;
using HTMLLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace HTMLLesson.Context
{
    public class MSUDBContext: DbContext
    {
        public MSUDBContext() { }
        public MSUDBContext(DbContextOptions<MSUDBContext> options): base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.SqlServerConnectionString);
        }
    }
}

//An unhandled exception occurred while processing the request.
//InvalidOperationException: 
//    Unable to resolve service for type 'HTMLLesson.Context.MSUDBContext' while attempting to activate 'HTMLLesson.Controllers.UserController'.