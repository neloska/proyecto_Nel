using Microsoft.AspNetCore.Mvc;
using proyecto_Nel.Data;
using System.Linq;

namespace proyecto_Nel.Controllers
{
    public class propietariosController : Controller
    {
        private readonly AppDbContext _context;

        public propietariosController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.propietario.ToList();
            return View(data);
        }
    }
}
