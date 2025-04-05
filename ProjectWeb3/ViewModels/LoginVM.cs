using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ProjectWeb3.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
        [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
        public string Email { get; set; }

        [Display(Name = "Senha de Acesso", Prompt = "**********")]
        [Required(ErrorMessage = "Por favor, informe sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Manter Conectado?")]
        public bool Lembrar { get; set; }
        public string UrlRetorno { get; set; }
    }
}