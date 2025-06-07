using AppDC_Hernández.Models;
using AppDC_Hernández.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppDC_Hernández.Controllers
{
    public class ConsultarController : Controller
    {
        private readonly DbecarioHernandezContext _context;

        public ConsultarController(DbecarioHernandezContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TReclamos.ToListAsync());
        }
    }
}
