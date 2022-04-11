using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Data;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    public class propiedadesController : Controller
    {
        private readonly AppDbContext _context;

        public propiedadesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allpropiedades = await _context.propiedades.Include(n => n.ciudades).OrderBy(n => n.Nombre).ToListAsync();
            return View(allpropiedades);
        }
    }
}
