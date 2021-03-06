﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
    public class ProjetoViewModel
    {
	    public ProjetoViewModel()
	    {
		    ProjetoId = new Guid();
	    }

        [Key]
        public Guid ProjetoId { get; set; }

		[DisplayName("Código do Projeto")]
		[Required(ErrorMessage = "Preencha o campo Código do Pojeto")]
        public int CodigoProjeto { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Projeto")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres ")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Nome do Projeto")]
        public string NomeProjeto { get; set; }

        [Required(ErrorMessage = "Preencha o campo Ativo")]
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
    }
}