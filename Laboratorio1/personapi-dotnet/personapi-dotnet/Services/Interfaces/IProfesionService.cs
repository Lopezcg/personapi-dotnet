using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Services.Interfaces
{
    public interface IProfesionService
    {
        IEnumerable<Profesion> GetAll();
        Profesion? GetById(int id);
        void Add(Profesion profesion);
        void Update(Profesion profesion);
        void Delete(int id);
    }
}
