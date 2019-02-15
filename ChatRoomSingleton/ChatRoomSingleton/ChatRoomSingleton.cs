using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomSingleton
{
  public class ChatRoomSingleton
    {
        private static ChatRoomSingleton sharedInstance;

       public List<Message> messages = new List<Message>();

        
       
        
        public void SendMessage (string message, User user)
        {
            Message mensaje = new Message(message, user);
            this.messages.Add(mensaje);
        }
        public void PrintChatMessages()
        {
            foreach (Message var in messages)
            {
                Console.WriteLine(var);
            }
        }
        public static ChatRoomSingleton GetChatRoom()
        {
            if (sharedInstance == null)
            {
                sharedInstance = new ChatRoomSingleton();
            }

            return sharedInstance;
        }


    }
}
