using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.RequestDTO
{
    public class PostFilmeDTO
    {
        [Required(ErrorMessage = "Nome do Filme é Obrigatório!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O filme deve ter no máximo 50 caracters, e no mínimo 5")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O preço do Filme é Obrigatório!")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "A foto do Filme é Obrigatória!")]
        public string ImageURL { get; set; }

        #region relacionamentos
        public string NomeCinema { get; set; }
        [Required(ErrorMessage = "O id do produtor é Obrigatório!")]
        public int ProdutorId { get; set; }
        [Required(ErrorMessage = "O id do cinema é Obrigatório!")]
        public int CinemaId { get; set; }

        public List<int> AtoresId { get; set; }
        public List<int> CategoriasId { get; set; } 
        #endregion
    }
}
