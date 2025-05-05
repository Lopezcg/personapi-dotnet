using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Services.Interfaces
{
    public interface IEstudiosService
    {
        IEnumerable<Estudio> GetAll();
        Estudio? GetById(int cc_per, int id_prof);
        void Add(Estudio estudio);
        void Update(Estudio estudio);
        void Delete(int cc_per, int id_prof);
    }
}
