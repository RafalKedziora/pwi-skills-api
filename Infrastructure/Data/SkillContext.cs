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
        public DbSet<TechStack> TechStacks { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ProjectAuthor> ProjectAuthors { get; set; }
        public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(eb =>
            {
                eb
                .HasMany(p => p.Details)
                .WithOne(pd => pd.Project)
                .HasForeignKey(pd => pd.ProjectId);

                eb
                .HasMany(p => p.Comments)
                .WithOne(pd => pd.Project)
                .HasForeignKey(pd => pd.ProjectId);
            });

            modelBuilder.Entity<ProjectAuthor>().HasKey(pa => new { pa.ProjectId, pa.AuthorId });
            modelBuilder.Entity<ProjectTechnology>().HasKey(pt => new { pt.ProjectId, pt.TechnologyId });
        }
    }
}
