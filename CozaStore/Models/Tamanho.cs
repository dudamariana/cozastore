using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Tamanho")]

    public class Tamanho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id {get; set; }

          [Required(ErrorMessage = "Informe a sigla")]
        [StringLength(30, ErrorMessage = "A sigla deve possuir no máximo 5 caracteres")]
        public string Sigla {get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Nome {get; set; }     
          public ICollection<ProdutoEstoque> Estoques { get; set; }   
    }
