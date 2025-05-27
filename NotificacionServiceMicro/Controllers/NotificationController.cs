using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers
{
    [ApiController]

    [Route("api/notifications")]
    public class NotificationController : ControllerBase
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(NotificationController));

        [HttpPost("email")]
        public IActionResult SendEmail([FromBody] NotificationRequest request)
        {
            _logger.Info($"Enviando correo a {request.Email} con mensaje: {request.Message}");
            return Ok();
        }
    }
    public record NotificationRequest(string Email, string Message);
}
