using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            RunChatRoom();
            Console.Read();
            
        }

        public static void RunChatRoom()
        {
            User u1 = new User("Ariel");
            u1.Chat.SendMessage("Hola!", u1);
            u1.Chat.PrintChatMessages();
           
        }
    }
}
