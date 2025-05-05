using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Services.Implementations
{
    public class TelefonoService : ITelefonoService
    {
        private readonly persona_dbContext _context;

        public TelefonoService(persona_dbContext context)
        {
            _context = context;
        }

        public IEnumerable<Telefono> GetAll() => _context.Telefonos.ToList();

        public Telefono? GetById(string num) => _context.Telefonos.Find(num);

        public void Add(Telefono telefono)
        {
            _context.Telefonos.Add(telefono);
            _context.SaveChanges();
        }

        public void Update(Telefono telefono)
        {
            _context.Telefonos.Update(telefono);
            _context.SaveChanges();
        }

        public void Delete(string num)
        {
            var tel = _context.Telefonos.Find(num);
            if (tel != null)
            {
                _context.Telefonos.Remove(tel);
                _context.SaveChanges();
            }
        }
    }
}
