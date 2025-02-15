using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectWeb3.Models
{
    [Table("Produto_foto")]
    public class ProdutoFoto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o produto")]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        [Display(Name = "Arquivo")]
        [Required(ErrorMessage = "Por favor, informe o arquivo")]
        [StringLength(300)]
        public string ArquivoFoto { get; set; } 

        [Display(Name = "Descrição")]
        [StringLength(100, ErrorMessage = "A descrição deve possuir no maximo 100 caracteres")]
        public string Descricao { get; set; }  
    }
}