using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("Jogo")]
    public class JogoModel
    {
        //Código, Nome, Data Lançamento, Plataforma (Enum), Disponível (bool) e Gênero.
        [Column("CodJogo"), HiddenInput()]   
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                _ = DateTime.Now;
            }
        }
        public Plataforma plataforma { get; set; }
        public bool Disponivel { get; set; }
        public int GeneroId { get; set; }
        public GeneroModel Genero { get; set; }
    }
}
