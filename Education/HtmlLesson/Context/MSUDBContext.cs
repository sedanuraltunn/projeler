using HtmlLesson.Helper;
using HtmlLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace HtmlLesson.Context
{
    public class MSUDBContext : DbContext
    {
        public MSUDBContext()
        {

        }
        public MSUDBContext(DbContextOptions<MSUDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
    }
}
