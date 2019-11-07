using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("Genero")]
    public class GeneroModel
    {
        //Código, Nome e Lista de Jogos;
        [Column("CodGenero"), HiddenInput()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<JogoModel> Jogos { get; set; }
    }
}
