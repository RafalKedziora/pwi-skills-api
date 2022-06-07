using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITechnologyService
    {
        ListTechStacksDto GetAllTechStacks();
        TechStackDto GetTechStackById(int id);
        TechStackDto AddTechStack(CreateTechStackDto newTechStack);
        void UpdateTechStack(UpdateTechStackDto techStack);
        void DeleteTechStack(int id);
    }
}
