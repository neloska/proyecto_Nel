using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Data;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    public class empleadosController : Controller
    {
        private readonly AppDbContext _context;

        public empleadosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allempleados = await _context.empleados.ToListAsync();
            return View(allempleados);
        }
    }
}
