﻿namespace ApiMiniSistema.DTOs
{
    public class RespuestaAutenticacionDTO
    {
        public required string Token {  get; set; }
        public DateTime Expiracion { get; set; }
    }
}
