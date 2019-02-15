using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomSingleton
{
   public class User
    {
        public ChatRoomSingleton Chat { get; set;}
        public string Name { get; set;}

        public User(string name)
        {
            this.Name = name;
            this.Chat = ChatRoomSingleton.GetChatRoom();
        }
    }
}
