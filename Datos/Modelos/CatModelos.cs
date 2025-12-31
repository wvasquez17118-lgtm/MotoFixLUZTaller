using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Modelos
{
    [Table("Cat_Modelo")]
    public class CatModelos
    {
        [Key]
        [Column("CatModeloId")]
        public int CatModeloId { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
}
