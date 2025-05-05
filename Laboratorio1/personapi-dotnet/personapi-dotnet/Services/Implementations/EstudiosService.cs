using personapi_dotnet.Models;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Services.Implementations
{
    public class EstudiosService : IEstudiosService
    {
        private readonly persona_dbContext _context;

        public EstudiosService(persona_dbContext context)
        {
            _context = context;
        }

        public IEnumerable<Estudio> GetAll()
        {
            return _context.Estudios.ToList();
        }

        public Estudio? GetById(int cc_per, int id_prof)
        {
            return _context.Estudios.Find(cc_per, id_prof);
        }

        public void Add(Estudio estudio)
        {
            _context.Estudios.Add(estudio);
            _context.SaveChanges();
        }

        public void Update(Estudio estudio)
        {
            _context.Estudios.Update(estudio);
            _context.SaveChanges();
        }

        public void Delete(int cc_per, int id_prof)
        {
            var estudio = _context.Estudios.Find(cc_per, id_prof);
            if (estudio != null)
            {
                _context.Estudios.Remove(estudio);
                _context.SaveChanges();
            }
        }
    }
}
