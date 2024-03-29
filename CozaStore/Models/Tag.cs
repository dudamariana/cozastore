using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Tag")]

    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id {get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Nome {get; set; }        
         public ICollection<ProdutoTag> Produtos { get; set; }
    }
