using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Column("Id")]
        [Display(Name = "Código do colaborador")]
        public int Id { get; set; }

        [Column("ColaboradorNome")]
        [Display(Name = "Nome do colaborador")]
        public string ColaboradorNome { get; set; } = string.Empty;

        [Column("ColaboradorCpf")]
        [Display(Name = "CPF do colaborador")]
        public string ColaboradorCpf { get; set; } = string.Empty;

        [Column("ColaboradorSexo")]
        [Display(Name = "Sexo do colaborador")]
        public string ColaboradorSexo { get; set; } = string.Empty;

        [Column("ColaboradorTelefone")]
        [Display(Name = "Telefone do colaborador")]
        public string ColaboradorTelefone { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade do cliente")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

        [ForeignKey("TipoColaboradorId")]
        [Display(Name = "Código do tipo de colaborador")]
        public int TipoColaboradorId { get; set; }

        public TipoColaborador? TipoColaborador { get; set; }
    }
}
