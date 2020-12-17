namespace maestro_web_app.MassTransit
{
    public class RabbitMQSettings
    {
        public string Hostname { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
        public string Username { get; set; }
    }
}
