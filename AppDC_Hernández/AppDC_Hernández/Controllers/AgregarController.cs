using AppDC_Hernández.Models;
using AppDC_Hernández.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AppDC_Hernández.Controllers
{
    public class AgregarController : Controller
    {
        private readonly DbecarioHernandezContext _context;

        public AgregarController(DbecarioHernandezContext context   )
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("~/Views/Reclamos/Reclamo_Hoja.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Guardar(ReclamoViewModel model)
        {
           if (ModelState.IsValid)
            {
                bool existeDui = _context.TReclamos.Any(r => r.Dui == model.DUI);
                if (existeDui)
                {
                    ModelState.AddModelError("DUI", "Este DUI ya está registrado.");
                    return View("~/Views/Reclamos/Reclamo_Hoja.cshtml", model);
                }

                //en caso sea unico
                var reclamo = new TReclamo
                {
                    NombreProveedor = model.NombreProveedor,
                    DireccionProveedor = model.DireccionProveedor,
                    NombresConsumidor = model.NombresConsumidor,
                    ApellidosConsumidor = model.ApellidosConsumidor,
                    Dui = model.DUI,
                    DettalleReclamo = model.DettalleReclamo,
                    MontoReclamado = model.MontoReclamado,
                    Telefono = model.Telefono,
                    FechaIngrese = DateTime.Now
                };

                _context.TReclamos.Add(reclamo);
                _context.SaveChangesAsync();
                ModelState.Clear();
                return View("~/Views/Reclamos/Reclamo_Hoja.cshtml", new ReclamoViewModel());
            }
            ModelState.Clear();
            return View("~/Views/Reclamos/Reclamo_Hoja.cshtml");

        }
    }
}
