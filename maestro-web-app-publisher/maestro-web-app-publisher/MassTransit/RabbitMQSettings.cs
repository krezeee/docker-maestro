using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maestro_web_app_publisher.MassTransit
{
    public class RabbitMQSettings
    {
        public string Hostname { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
        public string Username { get; set; }
    }
}
