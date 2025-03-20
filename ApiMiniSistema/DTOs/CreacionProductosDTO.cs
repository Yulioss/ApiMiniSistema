using System.ComponentModel.DataAnnotations;

namespace ApiMiniSistema.DTOs
{
    public class CreacionProductosDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public required string nombre { get; set; }
        public int cantidad { get; set; }
    }
}
