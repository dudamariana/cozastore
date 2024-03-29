using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Cor")]

    public class Cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id {get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Nome {get; set; }
        
           [Display(Name = "Código da Cor")]
           [Required(ErrorMessage = "Informe o Código da cor")]
        [StringLength(30, ErrorMessage = "O código da cor deve possuir no máximo 7 caracteres")]
        public string CodigoHexa {get; set; }
          public ICollection<ProdutoEstoque> Estoques { get; set; }
    }
