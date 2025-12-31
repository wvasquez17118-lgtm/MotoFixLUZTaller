using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Modelos
{
    [Table("IngresoTallerDetalles")]
    public class IngresoTallerDetalles
    {
        [Key]
        [Column("IngresoTallerDetalleId")]
        public long IngresoTallerDetalleId { get; set; }
        public long IngresoTallerId { get; set; }
        public long CatTrabajoRealizadoId { get; set; }
        public bool StatusTrabajoRealizado { get; set; }
        public string Observacion { get; set; } = string.Empty;        
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
    }
}
