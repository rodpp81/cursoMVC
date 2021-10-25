﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo é obrigatorio")]
        public String Descricao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
