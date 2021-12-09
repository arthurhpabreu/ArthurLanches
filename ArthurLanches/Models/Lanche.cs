using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArthurLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O tamanho minimo é de 10 caracteres e o máximo de 80")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho minimo é de 20 caracteres e o máximo de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição do lanche")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho minimo é de 20 caracteres e o máximo de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage="Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco{ get; set; }

        [Display(Name = "Caminho de Imagem normal")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho de Imagem miniatura")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
