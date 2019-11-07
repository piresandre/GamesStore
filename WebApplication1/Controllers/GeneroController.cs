using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class GeneroController : Controller
    {
        private IGeneroRepository _repository;
        private IJogoRepository _jogoRepository;

        public GeneroController(IGeneroRepository repository,
            IJogoRepository jogoRepository)
        {
            _repository = repository;
            _jogoRepository = jogoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastroGenero()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroGenero(GeneroModel genero)
        {
            _repository.CadastrarGenero(genero);
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("CadastroGenero");
        }

    }
}