using LanchesMac.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        [Range(1, 999999, ErrorMessage = "numero de registro excedido")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite o nome!")]
        [MaxLength(100, ErrorMessage = "Limite de caracter excedido!!")]
        public string Nome { get; set; }

        [Display(Name = "Descrição Curta")]
        [MaxLength(100, ErrorMessage = "Limite de caracter excedido!!")]
        [Required(ErrorMessage = "Precisa digitar uma descrição curta para o produto!")]
        public string DescricaoCurta { get; set; }

        [Display(Name = "Descrição Longa")]
        [MaxLength(300, ErrorMessage = "Limite de caracter excedido!!")]
        public string DescricaoLonga { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Preço")]
        [Range(1, 99999999.9, ErrorMessage = "Preço Inválido!")]
        [Required(ErrorMessage = "O produto precisa do seu preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem do Produto")]
        public string ImgUrl { get; set; }

        [Display(Name = "Thumbnails do Produto")]
        public string ImgThumbnails { get; set; }

        [Display(Name = "Preferido?")]
        [Required]
        public bool IsPreferido { get; set; }

        [Display(Name = "Estoque")]
        [Required]
        public bool IsEstoque { get; set; }

        public int categoriaId { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}