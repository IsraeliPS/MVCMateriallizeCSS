using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turnos.Models;

//aqui puede ser turnos con minuscula
namespace Turnos.Controllers
{
  public class PacienteController : Controller
  {
      private readonly TurnosContext _context;

      public PacienteController (TurnosContext context)
      {
        _context=context;
      }

      public async Task<IActionResult> Index()
      {
        return View(await _context.Paciente.ToListAsync());
      }
  }
}