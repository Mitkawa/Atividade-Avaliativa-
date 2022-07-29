using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.ResponseDTO
{
    public class GetFilmeDTO
    {
        [Display(Name = "Titulo")]
        public string Titulo { get; private set; }
        [Display(Name = "Descricao")]
        public string Descricao { get; private set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; private set; }
        [Display(Name = "Foto filme")]
        public string ImageURL { get; private set; }
        public List<string> FilmesCategorias { get; set; }
        public string Produtor { get; set; }
    }
}
