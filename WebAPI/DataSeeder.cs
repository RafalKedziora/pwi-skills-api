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
                }
                if (!_skillContext.Comments.Any())
                {
                    var comments = GetComments();
                }
                if(!_skillContext.Languages.Any())
                {
                    var languages = GetLanguages();
                }
                if (!_skillContext.Projects.Any())
                {
                    var projects = GetProjects();
                }
                if (!_skillContext.Technologies.Any())
                {
                    var technologies = GetTechnologies();

                    var relations = GetRelations();
                }
            }
        }

        private object GetRelations()
        {
            throw new NotImplementedException();
        }

        private object GetTechnologies()
        {
            throw new NotImplementedException();
        }

        private object GetProjects()
        {
            throw new NotImplementedException();
        }

        private object GetLanguages()
        {
            throw new NotImplementedException();
        }

        private object GetComments()
        {
            throw new NotImplementedException();
        }

        private object GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
