using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Código do tipo de procedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Tipo de procedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
