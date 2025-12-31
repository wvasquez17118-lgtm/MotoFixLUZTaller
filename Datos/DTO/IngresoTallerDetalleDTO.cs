namespace Datos.DTO
{
    public class IngresoTallerDetalleDTO
    {
        public long IngresoTallerDetalleId { get; set; }
        public long CatTrabajoRealizadoId { get; set; }
        public string TrabajoRealizado { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool StatusTrabajoRealizado { get; set; }
    }
}