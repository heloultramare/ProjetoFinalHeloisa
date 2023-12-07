using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código do procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome do procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Resultado do procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoProcedimentoId")]
        [Display(Name = "Código do tipo do procedimento")]
        public int TipoProcedimentoId { get; set; }

        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
