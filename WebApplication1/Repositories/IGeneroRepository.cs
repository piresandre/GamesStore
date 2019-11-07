using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IGeneroRepository
    {
        void CadastrarGenero(GeneroModel genero);
        List<GeneroModel> ListarGenero();
        void ExcluirGenero(int id);
        void AlterarGenero(GeneroModel genero);
        GeneroModel BuscarGenero(int generoId);
    }
}
