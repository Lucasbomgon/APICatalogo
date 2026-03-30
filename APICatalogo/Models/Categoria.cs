using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace APICatalogo.Models;

[Table("Categoria")]
public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80, ErrorMessage = "Voce precisa colocar um nome para a categoria")]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300, ErrorMessage = "A imagem deve ter no maximo {1} caracteres", 
    MinimumLength = 10)]
    public string? ImagemUrl { get; set; }

    public ICollection<Produto> Produtos { get; set; } 

}
