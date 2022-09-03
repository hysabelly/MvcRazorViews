using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller 

{
    // private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>();

        private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>
        {
            new EstudanteViewModel(1, "Maria da Silva", "Rua X, 1", true),
            new EstudanteViewModel(2, "João Santos", "Rua Y, 2", true),
            new EstudanteViewModel(3, "Pedro Campos", "Rua Z, 3", false),
            new EstudanteViewModel(4, "Carla Gomes", "Rua C, 4", true)
        };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}