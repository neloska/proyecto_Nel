using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_Nel.Data.Services
{
    public class propietariosService : IPropietariosService
    {
        private readonly AppDbContext _context;
        //constructor
        public propietariosService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(propietario propietario)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<propietario>> GetAll()
        {
            var result = await _context.propietario.ToListAsync();
            return result;
        }

        public propietario GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public propietario Update(int id, propietario newpropietario)
        {
            throw new System.NotImplementedException();
        }
    }
}
