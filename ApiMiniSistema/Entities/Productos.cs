using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMiniSistema.Entities
{
    [Table("productos")]
    public class Productos
    {
        [Key]
        public int id { get; set; }
        public string? nombre { get; set; }
        public int cantidad { get; set; }
        public string? movimiento { get; set; }
    }
}
