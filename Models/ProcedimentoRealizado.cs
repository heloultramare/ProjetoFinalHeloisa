using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("Id")]
        [Display(Name = "Código do procedimento realizado")]
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        [Display(Name = "Procedimento")]
        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        [Display(Name = "Colaborador")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        [Display(Name = "Local de realização")]
        public int? LocalRealizacaoId { get; set; }

        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data da realização")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Resultado da realização")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;
    }
}
