using Domain.Entities;
using Infrastructure.Data;

namespace WebAPI
{
    public class DataSeeder
    {
        private readonly SkillContext _skillContext;
        public DataSeeder(SkillContext skillContext)
        {
            _skillContext = skillContext;
        }
        
        public void Seed()
        {
            if(_skillContext.Database.CanConnect())
            {
                if (!_skillContext.Authors.Any())
                {
                    var authors = GetAuthors();
                    _skillContext.Authors.AddRange(authors);
                    _skillContext.SaveChanges();
                }
                if(!_skillContext.Languages.Any())
                {
                    var languages = GetLanguages();
                    _skillContext.Languages.AddRange(languages);
                    _skillContext.SaveChanges();
                }
                if (!_skillContext.Projects.Any())
                {
                    var projects = GetProjects();
                    _skillContext.Projects.AddRange(projects);
                    _skillContext.SaveChanges();
                }
                if (!_skillContext.TechStacks.Any())
                {
                    var technologies = GetTechnologies();
                    _skillContext.TechStacks.AddRange(technologies);
                    _skillContext.SaveChanges();
                }
                if (!_skillContext.Comments.Any())
                {
                    var comments = GetComments();
                    _skillContext.Comments.AddRange(comments);
                    _skillContext.SaveChanges();
                }
                if (!_skillContext.ProjectAuthors.Any())
                {
                    var projectAuthors = GetProjectAuthor();
                    _skillContext.ProjectAuthors.AddRange(projectAuthors);
                    _skillContext.SaveChanges();
                }
                if (!_skillContext.ProjectDetails.Any())
                {
                    var projectDetails = GetProjectDetails();
                    _skillContext.ProjectDetails.AddRange(projectDetails);
                    _skillContext.SaveChanges();
                }
                if (!_skillContext.ProjectTechnologies.Any())
                {
                    var projectTechnologies = GetProjectTechnology();
                    _skillContext.ProjectTechnologies.AddRange(projectTechnologies);
                    _skillContext.SaveChanges();
                }
            }
        }

        private IEnumerable<ProjectAuthor> GetProjectAuthor()
        {
            var projectauthor = new List<ProjectAuthor>()
            {
                new ProjectAuthor
                {
                    ProjectId = 1,
                    AuthorId = 1
                },
                new ProjectAuthor
                {
                    ProjectId = 1,
                    AuthorId = 2
                },
                new ProjectAuthor
                {
                    ProjectId = 2,
                    AuthorId = 3
                },
                new ProjectAuthor
                {
                    ProjectId = 2,
                    AuthorId = 4
                },                
            };
            return projectauthor;
        }

        private IEnumerable<ProjectDetails> GetProjectDetails()
        {
            var projectDetails = new List<ProjectDetails>()
            { 
                new ProjectDetails()
                {
                    LanguageId = 1,
                    Name = "Project 1",
                    About = "Project 1 About",
                    Description = "Project 1 Description",
                    ProjectId = 1
                },
                new ProjectDetails()
                {
                    LanguageId = 2,
                    Name = "Projekt 1",
                    About = "Projekt 1 O projekcie",
                    Description = "Projekt 1 Opis",
                    ProjectId = 1
                },
                new ProjectDetails()
                {
                    LanguageId = 1,
                    Name = "Project 2",
                    About = "Project 2 About",
                    Description = "Project 2 Description",
                    ProjectId = 2
                },
                new ProjectDetails()
                {
                    LanguageId = 2,
                    Name = "Projekt 2",
                    About = "Projekt 2 O projekcie",
                    Description = "Projekt 2 Opis",
                    ProjectId = 2
                }                
            };
            return projectDetails;
        }

        private IEnumerable<ProjectTechnology> GetProjectTechnology()
        {
            var projectTechnologies = new List<ProjectTechnology>()
            {
                new ProjectTechnology()
                {
                    ProjectId = 1,
                    TechnologyId = 1
                },
                new ProjectTechnology()
                {
                    ProjectId = 1,
                    TechnologyId = 2
                },
                new ProjectTechnology()
                {
                    ProjectId = 2,
                    TechnologyId = 3
                },
                new ProjectTechnology()
                {
                    ProjectId = 2,
                    TechnologyId = 1
                }
            };
            return projectTechnologies;
        }

        private IEnumerable<TechStack> GetTechnologies()
        {
            var technologies = new List<TechStack>()
            {
                new TechStack()
                {
                    Name = "C#"
                },
                new TechStack()
                {
                    Name = "Java"
                },
                new TechStack()
                {
                    Name = "Python"
                },
            };

            return technologies;
        }

        private IEnumerable<Project> GetProjects()
        {
            var projects = new List<Project>()
            {
                new Project()
                {
                    isActive = true
                },
                new Project()
                {
                    isActive = true
                },
                new Project()
                {
                    isActive = true
                }                
            };
            return projects;
        }

        private IEnumerable<Language> GetLanguages()
        {
            var languages = new List<Language>()
            {    
                new Language()
                {
                    Name = "English",
                    Code = "EN",
                    NativeName = "English",
                    Locale = "en-US"
                },
                new Language()
                {
                    Name = "Polish",
                    Code = "PL",
                    NativeName = "Polski",
                    Locale = "pl-PL"
                }
            };
            return languages;
        }

        private IEnumerable<Comment> GetComments()
        {
            var comments = new List<Comment>()
            {
                new Comment()
                {
                    Message = "This is a comment",
                    Author = "John Doe",
                    ProjectId = 1
                },
               new Comment()
                {
                    Message = "This is a comment 2",
                    Author = "Andrzej Bagieta",
                    ProjectId = 1
                },
               new Comment()
                {
                    Message = "This is a comment",
                    Author = "Stefan Bagieta",
                    ProjectId = 2
                },
               new Comment()
                {
                    Message = "This is a comment",
                    Author = "Olga Tokarczuk",
                    ProjectId = 3
                },
            };
            return comments;
        }

        private IEnumerable<Author> GetAuthors()
        {
            var authors = new List<Author>()
            {
                new Author()
                {
                    NickName = "MelonDusk"
                },
                new Author()
                {
                    NickName = "JoAndrzej22"
                },
                new Author()
                {
                    NickName = "JoAnna213"
                },
                new Author()
                {
                    NickName = "JadwigaKorzenna"
                },
            };
            return authors;
        }
    }
}
