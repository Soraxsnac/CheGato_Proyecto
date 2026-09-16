using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CheGato.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConexionController : ControllerBase
    {
        private readonly string _cadenaConexion;

        public ConexionController(IConfiguration config)
        {
            _cadenaConexion = config.GetConnectionString("DefaultConnection");
        }

        // HU-1.1: Prueba de Conexión (Ping)
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_cadenaConexion))
                {
                    con.Open(); // Si logra abrir, la conexión es exitosa
                }
                return Ok(new { mensaje = "¡Conexión Exitosa con SQL Server, miau! 🐾" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Servidor no disponible o base de datos apagada.", error = ex.Message });
            }
        }
    }
}