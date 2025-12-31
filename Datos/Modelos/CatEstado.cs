using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos.Modelos
{
    [Table("Cat_Estado")]
    public class CatEstado
    {
        [Key]
        [Column("CatEstadoId")]
        public int CatEstadoId { get; set; }
        public string NombreEstado { get; set; } = string.Empty;
        public int Codigo { get; set; }
        public bool Estado { get; set; }
    }
}
