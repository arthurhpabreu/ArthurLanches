using ArthurLanches.Repositories.Interfaces;
using ArthurLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ArthurLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();
            ViewBag.TotalLanches = totalLanches;

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
}
