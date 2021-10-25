using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoMVC.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public String Descricao { get; set; }
        
    }
}
