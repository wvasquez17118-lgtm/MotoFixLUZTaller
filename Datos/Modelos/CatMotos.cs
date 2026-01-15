using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos.Modelos
{
    [Table("Cat_Motos")]
    public class CatMotos
    {
        [Key]
        [Column("CatMotoId")]
        public long CatMotoId { get; set; }
		public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
		public string Placa {  get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Cilindrada { get; set; } = string.Empty;
        public bool Estado {  get; set; }
    }
}