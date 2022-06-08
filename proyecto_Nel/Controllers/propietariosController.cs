using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using proyecto_Nel.Data;
using proyecto_Nel.Data.Services;
using proyecto_Nel.Models;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    [Authorize]
    public class propietariosController : Controller
    {
        private readonly IPropietariosService _service;

        public propietariosController(IPropietariosService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAllAsync();
            return View(data);
        }

        //Get: propietarios/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("NombreCompleto,FotoDePerfilURL,DescripcionPropietario")] propietario propietarios)
        {
            if (!ModelState.IsValid)
            {
                return View(propietarios);
            }
            await _service.AddAsync(propietarios);
            return RedirectToAction(nameof(Index));
        }

        //Get: propietarios/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var propietariosDetails = await _service.GetByIdAsync(id);

            if (propietariosDetails == null) return View("NotFound");
            return View(propietariosDetails);
        }

        //Get: propietarios/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var propietariosDetails = await _service.GetByIdAsync(id);
            if (propietariosDetails == null) return View("NotFound");
            return View(propietariosDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("IdPropietario,NombreCompleto,FotoDePerfilURL,DescripcionPropietario")] propietario propietarios)
        {
            if (!ModelState.IsValid)
            {
                return View(propietarios);
            }
            await _service.UpdateAsync(id, propietarios);
            return RedirectToAction(nameof(Index));
        }

        //Get: propietarios/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var propietariosDetails = await _service.GetByIdAsync(id);
            if (propietariosDetails == null) return View("NotFound");
            return View(propietariosDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propietariosDetails = await _service.GetByIdAsync(id);
            if (propietariosDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
