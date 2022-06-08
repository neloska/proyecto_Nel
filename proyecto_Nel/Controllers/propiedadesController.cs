using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Data;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    [Authorize]
    public class propiedadesController : Controller
    {
        private readonly AppDbContext _context;

        public propiedadesController(AppDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allpropiedades = await _context.propiedades.Include(n => n.ciudades).OrderBy(n => n.NombrePropiedad).ToListAsync();
            return View(allpropiedades);
        }
        //filtro de busqueda 
        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allpropiedades = await _context.propiedades.Include(n => n.ciudades).OrderBy(n => n.NombrePropiedad).ToListAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var resutadoFiltro= allpropiedades.Where(n => n.NombrePropiedad.Contains(searchString)).ToList();
                return View("Index", resutadoFiltro);
            }

            return View("Index", allpropiedades);
        }
    }
}
