using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private GameStoreContext _context;
        public GeneroRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void AlterarGenero(GeneroModel genero)
        {
            var oldGenero = _context.Genero.Find(genero.Id);
            oldGenero.Id = genero.Id;
            oldGenero.Nome = genero.Nome;
            oldGenero.Jogos = genero.Jogos;
            _context.Attach(genero).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public GeneroModel BuscarGenero(int generoId)
        {
            return _context.Genero.Find(generoId);
        }

        public void CadastrarGenero(GeneroModel genero)
        {
            _context.Genero.Add(genero);
            _context.SaveChanges();
        }

        public void ExcluirGenero(int id)
        {
            var genero = _context.Genero.Find(id);
            _context.Genero.Remove(genero);
            _context.SaveChanges();
        }

        public List<GeneroModel> ListarGenero()
        {
            return _context.Genero.ToList();
        }
    }
}
