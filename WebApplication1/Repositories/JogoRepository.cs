using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private GameStoreContext _context;
        public JogoRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void AlterarJogo(JogoModel jogo)
        {
            _context.Jogo.Update(jogo);
            _context.SaveChanges();
        }

        public JogoModel BuscarJogo(int id)
        {
            return _context.Jogo.Find(id);
        }

        public void CadastrarJogo(JogoModel jogo)
        {
            _context.Jogo.Add(jogo);
            _context.SaveChanges();
        }

        public void ExcluirJogo(int id)
        {
            var oldJogo = _context.Jogo.Find(id);
            _context.Jogo.Remove(oldJogo);
            _context.SaveChanges();
        }

        public List<JogoModel> ListarJogo()
        {
            return _context.Jogo.ToList();
        }
    }
}
