using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SkillContext : DbContext
    {
        public SkillContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectAuthor>().HasKey(pa => new { pa.ProjectId, pa.AuthorId });
            modelBuilder.Entity<ProjectTechnology>().HasKey(pt => new { pt.ProjectId, pt.TechnologyId });
        }
    }
}
