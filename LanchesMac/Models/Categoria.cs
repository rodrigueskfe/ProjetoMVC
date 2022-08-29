using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;
[Table("Categorias")]
public class Categoria
{
    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Digite o nome!")]
    [MaxLength(100, ErrorMessage = "Limite de caracter excedido!")]
    public string categorianome { get; set; }

    [Key]
    [Range(1, 999999, ErrorMessage = "numero de registro excedido!")]
    public int categoriaId { get; set; }

    [Display(Name = "Descrição")]
    [MaxLength(300, ErrorMessage = "Limite de caracter excedido!")]
    public string descricao { get; set; }
    public List<Lanche> lanches { get; set; }

}
