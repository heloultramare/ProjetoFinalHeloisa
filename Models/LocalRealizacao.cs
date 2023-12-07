using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalHeloisa.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código do local")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome do local")]
        public string LocalNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade do cliente")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
