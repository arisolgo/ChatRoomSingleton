using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomSingleton
{
    public class Message
    {
        public string message { get; set; }
        public DateTime time { get; }
        public User usuario { get; set; }

        public Message(string mensaje, User user)
        {
            this.message = mensaje;
            this.usuario = user;
            this.time = DateTime.Now;
        }
    }
}
