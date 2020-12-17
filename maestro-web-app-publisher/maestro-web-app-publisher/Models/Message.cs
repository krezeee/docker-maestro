using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maestro_web_app_publisher.Models
{
    public class Message
    {
        public string Value { get; }

        public Message(string value)
        {
            Value = value;
        }

    }
}
