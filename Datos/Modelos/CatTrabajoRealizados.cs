using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Modelos
{
    [Table("Cat_TrabajoRealizados")]
    public class CatTrabajoRealizados
    {
        [Key]
        [Column("CatTrabajoRealizadoId")]
        public long CatTrabajoRealizadoId { get; set; }
        public string TrabajoRealizado { get; set; } = string.Empty;
        public string Observacion { get; set; } = string.Empty;
        public bool Estado {  get; set; }
        public decimal ? PrecioEstimado { get; set; }

    }
}
