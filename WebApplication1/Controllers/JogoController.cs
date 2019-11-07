using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class JogoController : Controller
    {
        private IJogoRepository _repository;
        private IGeneroRepository _generoRepository;
        public JogoController(IJogoRepository repository,
            IGeneroRepository generoRepository)
        {
            _repository = repository;
            _generoRepository = generoRepository;
        }
        [HttpGet]
        public IActionResult CadastroJogo()

        {
            var generos = _generoRepository.ListarGenero();
            ViewBag.genero = new SelectList(generos, "Id", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarJogo(JogoModel jogo)
        {
            _repository.CadastrarJogo(jogo);
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("CadastroJogo");
        }

        public IActionResult ListaDeJogos()
        {
            var jogo = _repository.ListarJogo();
            foreach (var j in jogo)
            {
                j.Genero = _generoRepository.BuscarGenero(j.GeneroId);
            }
            return View(jogo);
        }


        
        public IActionResult FormAlteraJogo(int id)
        {
            var jogo = _repository.BuscarJogo(id);
            var generos = _generoRepository.ListarGenero();
            ViewBag.genero = new SelectList(generos, "Id", "Nome");
            return View(jogo);
        }
        public IActionResult AtualizarJogo(JogoModel jogo)
        {
            _repository.AlterarJogo(jogo);
            return RedirectToAction("ListaDeJogos");
        }
        public IActionResult RemoverJogo(int id)
        {
            var jogo = _repository.BuscarJogo(id);
            if (jogo.Disponivel)
            {
                _repository.ExcluirJogo(id);
            }
            return RedirectToAction("ListaDeJogos");
        }


    }
}