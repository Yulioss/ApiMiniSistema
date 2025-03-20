using System.ComponentModel.DataAnnotations;

namespace ApiMiniSistema.DTOs
{
    public class CredencialesUsuarioDTO
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
