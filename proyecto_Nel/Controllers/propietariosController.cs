using Microsoft.AspNetCore.Mvc;
using proyecto_Nel.Data;
using proyecto_Nel.Data.Services;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    public class propietariosController : Controller
    {
        private readonly IPropietariosService _service;

        public propietariosController(IPropietariosService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAll();
            return View(data);
        }
    }
}
