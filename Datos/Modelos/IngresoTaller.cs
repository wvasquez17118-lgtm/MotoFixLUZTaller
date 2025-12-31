using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Modelos
{
    [Table("IngresoTaller")]
    public class IngresoTaller
    {
        [Key]
        [Column("IngresoTallerId")]
        public long IngresoTallerId { get; set; }
        public long CatMotoId { get; set; }
        public int CatEstadoId { get; set; }
        public string KilometrajeIngreso { get; set; } = string.Empty;
        public string NombreCliente { get; set; } = string.Empty;
        public string CorreoCliente { get; set; } = string.Empty;
        public string CelularCliente { get; set; } = string.Empty;
        public string? DesProblemaDetallaCliente { get; set; } = string.Empty;
        public string? DesTrabajoDetallaCliente { get; set; } = string.Empty;
        public string? DesTrabajoDetallaMecanico { get; set; } = string.Empty;
        public string? ObservacionesTrabajoRealizado { get; set; } = string.Empty;
        public string? SugerenciaTrabajoRealizado { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }
        public bool Estado {  get; set; }
    }
}
