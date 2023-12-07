using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código do estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do estado")]
        public string EstadoNome { get; set; } = string.Empty;
    }
}
