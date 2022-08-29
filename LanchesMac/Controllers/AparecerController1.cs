using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;

namespace LanchesMac.Controllers;

public class AparecerController : Controller
{
    private readonly ILancheRepository lancheRepository;
    private ILancheRepository _lancheRepository;

    public AparecerController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }
    public IActionResult List()
    {
        var lanches = _lancheRepository.Lanches;
        return View(lanches);
    }
}
