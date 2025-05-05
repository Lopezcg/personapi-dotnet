using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Services.Implementations
{
    public class ProfesionService : IProfesionService
    {
        private readonly persona_dbContext _context;

        public ProfesionService(persona_dbContext context)
        {
            _context = context;
        }

        public IEnumerable<Profesion> GetAll() => _context.Profesions.ToList();

        public Profesion? GetById(int id) => _context.Profesions.Find(id);

        public void Add(Profesion profesion)
        {
            _context.Profesions.Add(profesion);
            _context.SaveChanges();
        }

        public void Update(Profesion profesion)
        {
            _context.Profesions.Update(profesion);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var profesion = _context.Profesions.Find(id);
            if (profesion != null)
            {
                _context.Profesions.Remove(profesion);
                _context.SaveChanges();
            }
        }
    }
}
