namespace ApiMiniSistema.DTOs
{
    public class RespuestaAutenticacionDTO
    {
        public required string token {  get; set; }
        public DateTime expiracion { get; set; }
    }
}
