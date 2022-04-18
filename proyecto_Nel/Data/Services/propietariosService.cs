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

        public async Task AddAsync(propietario propietario)
        {
            await _context.propietario.AddAsync(propietario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.propietario.FirstOrDefaultAsync(n => n.IdPropietario == id);
            _context.propietario.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<propietario>> GetAllAsync()
        {
            var result = await _context.propietario.ToListAsync();
            return result;
        }

        public  async Task<propietario> GetByIdAsync(int id)
        {
            var result = await _context.propietario.FirstOrDefaultAsync(n => n.IdPropietario == id);
            return result;
        }

        public async Task<propietario>UpdateAsync(int id, propietario newpropietario)
        {
            _context.Update(newpropietario);
            await _context.SaveChangesAsync();
            return newpropietario;
        }
    }
}
