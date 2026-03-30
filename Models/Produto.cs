using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace APICatalogo.Models;

[Table("Produtos")]
public class Produto
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage ="O nome é obrigatório")]  
    [StringLength(20, ErrorMessage ="O nome deve ter entre 5 a 20 caracteres",
    MinimumLength =5)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(10, ErrorMessage = "A descricao deve ter no maximo {1} caracteres")]
    public string? Descricao { get; set; }

    [Required]
    [Range(1, 10000, ErrorMessage = "O preco deve estar entre {1} e {2}")]
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300, MinimumLength = 10)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; }

    public Categoria? Categoria { get; set; }
}
