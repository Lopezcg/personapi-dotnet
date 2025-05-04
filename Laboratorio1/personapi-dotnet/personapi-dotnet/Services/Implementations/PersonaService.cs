using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Services.Implementations
{
    public class PersonaService : IPersonaService
    {
        private readonly persona_dbContext _context;

        public PersonaService(persona_dbContext context)
        {
            _context = context;
        }

        public IEnumerable<Persona> GetAll()
        {
            return _context.Personas.ToList();
        }

        public Persona? GetById(int id)
        {
            return _context.Personas.Find(id);
        }

        public void Add(Persona persona)
        {
            _context.Personas.Add(persona);
            _context.SaveChanges();
        }

        public void Update(Persona persona)
        {
            _context.Personas.Update(persona);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var persona = _context.Personas.Find(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                _context.SaveChanges();
            }
        }
    }
}
