using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IJogoRepository
    {
        void CadastrarJogo(JogoModel jogo);
        List<JogoModel> ListarJogo();
        void ExcluirJogo(int id);
        void AlterarJogo(JogoModel jogo);
        JogoModel BuscarJogo(int id);
    }
}
