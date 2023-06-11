using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AppleStoreTupinikim.Models
{
    [Table("Produtos")]
    public class ProdutoModel
    {
        [Key]
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
        [Display(Name = "Valor")]
        [Column("Valor")]
        public double Valor { get; set; }
        [Display(Name = "Estoque")]
        [Column("Estoque")]
        public int Estoque { get; set; }
    }
}
