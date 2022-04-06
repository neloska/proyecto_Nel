using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Data;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    public class ciudadesController : Controller
    {
        private readonly AppDbContext _context;

        public ciudadesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allempleados = await _context.ciudades.ToListAsync();
            return View();
        }
    }
}
