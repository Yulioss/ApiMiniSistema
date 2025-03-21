using System.ComponentModel.DataAnnotations;

namespace ApiMiniSistema.DTOs
{
    public class CredencialesUsuarioDTO
    {
        [Required]
        public required string userName { get; set; }
        [Required]
        public required string password { get; set; }
    }
}
