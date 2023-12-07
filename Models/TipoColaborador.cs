using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Código do tipo de colaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Tipo de colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
