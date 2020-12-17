using System.Threading.Tasks;
using maestro_web_app_publisher.Dtos;
using maestro_web_app_publisher.Models;
using maestro_web_app_publisher.Services;
using Microsoft.AspNetCore.Mvc;

namespace maestro_web_app_publisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageSender _messageSender;

        public MessageController(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        [HttpGet]
        public async Task<int> Get()
        {
            return await Task.FromResult(1);
        }

        [HttpPost]
        public void QueueMessage([FromBody] MessageDto dto)
        {
            _messageSender.SendMessage(new Message(dto.Message));
        }
    }
}
