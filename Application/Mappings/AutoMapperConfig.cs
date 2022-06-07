using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {

                #region Author

                cfg.CreateMap<Author, AuthorDto>();
                cfg.CreateMap<CreateAuthorDto, Author>();
                cfg.CreateMap<UpdateAuthorDto, Author>();
                cfg.CreateMap<IQueryable<Author>, ListAuthorsDto>()
                .ForMember(dest => dest.Authors, act => act.MapFrom(src => src))
                .ForMember(dest => dest.Count, act => act.MapFrom(src => src.Count()));

                #endregion

                #region Comment

                cfg.CreateMap<Comment, CommentDto>();
                cfg.CreateMap<CreateCommentDto, Comment>();
                cfg.CreateMap<UpdateCommentDto, Comment>();
                cfg.CreateMap<IQueryable<Comment>, ListCommentsDto>()
                .ForMember(dest => dest.Comments, act => act.MapFrom(src => src))
                .ForMember(dest => dest.Count, act => act.MapFrom(src => src.Count()));

                #endregion

                #region Language

                cfg.CreateMap<Language, LanguageDto>();
                cfg.CreateMap<CreateLanguageDto, Language>();
                cfg.CreateMap<UpdateLanguageDto, Language>();
                cfg.CreateMap<IQueryable<Language>, ListLanguagesDto>()
                .ForMember(dest => dest.Languages, act => act.MapFrom(src => src))
                .ForMember(dest => dest.Count, act => act.MapFrom(src => src.Count()));

                #endregion

                #region Project

                cfg.CreateMap<Project, ProjectDto>();
                cfg.CreateMap<CreateProjectDto, Project>();
                cfg.CreateMap<UpdateProjectDto, Project>();
                cfg.CreateMap<IQueryable<Project>, ListProjectsDto>()
                .ForMember(dest => dest.Projects, act => act.MapFrom(src => src))
                .ForMember(dest => dest.Count, act => act.MapFrom(src => src.Count()));

                #endregion

                #region Technology

                cfg.CreateMap<TechStack, TechStackDto>();
                cfg.CreateMap<CreateTechStackDto, TechStack>();
                cfg.CreateMap<UpdateTechStackDto, TechStack>();
                cfg.CreateMap<IQueryable<TechStack>, ListTechStacksDto>()
                .ForMember(dest => dest.TechStacks, act => act.MapFrom(src => src))
                .ForMember(dest => dest.Count, act => act.MapFrom(src => src.Count()));

                #endregion
            }).CreateMapper();
    }
}
