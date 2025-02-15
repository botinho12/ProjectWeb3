
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ProjectWeb3.Models
{
    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "Por favor insira o nome")]
        [StringLength(60, ErrorMessage = "O nome deve conter no maximo 60 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }
    }
}