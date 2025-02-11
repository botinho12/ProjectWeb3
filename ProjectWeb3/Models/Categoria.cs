using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectWeb3.Models;

[Table("Categoria")]
 public class Categoria
{     
    [Key]   
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor , informe o nome")]
    [StringLength(30,ErrorMessage = "O Nome deve conter no maximo 30 caracteres")]
    public string  Name  { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }
}
