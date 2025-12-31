using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos.Modelos
{
    [Table("Cat_Marca")]
    public class CatMarca
    {
        [Key]
        [Column("CatMarcaId")] 
        public int CatMarcaId { get; set; }
        public string Marca { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
}
