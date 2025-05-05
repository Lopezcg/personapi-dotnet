using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Services.Interfaces
{
    public interface ITelefonoService
    {
        IEnumerable<Telefono> GetAll();
        Telefono? GetById(string num);
        void Add(Telefono telefono);
        void Update(Telefono telefono);
        void Delete(string num);
    }
}
