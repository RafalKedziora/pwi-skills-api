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

                eb.HasMany(p => p.Authors)
                .WithMany(a => a.Projects)
                .UsingEntity<ProjectAuthor>();

                eb.HasMany(p => p.TechStacks)
                .WithMany(t => t.Projects)
                .UsingEntity<ProjectTechnology>(
                     w => w.HasOne(pt => pt.Technology)
                    .WithMany()
                    .HasForeignKey(pt => pt.TechnologyId),

                    w => w
                    .HasOne(pt => pt.Project)
                    .WithMany()
                    .HasForeignKey(pt => pt.ProjectId),

                     pt =>
                     {
                         pt.HasKey(x => new { x.ProjectId, x.TechnologyId });
                     });

                eb.HasMany(p => p.Authors)
                .WithMany(t => t.Projects)
                .UsingEntity<ProjectAuthor>(
                     w => w.HasOne(pt => pt.Author)
                    .WithMany()
                    .HasForeignKey(pt => pt.AuthorId),

                    w => w
                    .HasOne(pt => pt.Project)
                    .WithMany()
                    .HasForeignKey(pt => pt.ProjectId),

                     pt =>
                     {
                         pt.HasKey(x => new { x.ProjectId, x.AuthorId });
                     });
            });
        }
    }
}
