﻿using GoltaraSolutions.Common.Extensions;
using System.ComponentModel.DataAnnotations;

namespace GoltaraSolutions.Common.Identity.Models
{
    public class CadastroViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        [Display(Name = "Email de acesso")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Senha", ErrorMessage = "A senha e sua confirmação são divergentes.")]
        public string ConfirmarSenha { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(1, 3, ErrorMessage = "Escolha um Grupo de Acesso.")]
        [Display(Name = "Grupo de Acesso")]
        public GrupoDeAcesso Grupo { get; set; }

        public bool Deletado { get; set; }

        public string Ativo
        {
            get
            {
                return (!Deletado).ToCustomString();
            }
        }
    }
}
