using System.Collections.Generic;
using System;
using System.Linq;

namespace Patterns.Mediator.Chat
{
    public class ChatRoom
    {
        public List<User> Users { get; set; } = new List<User>();

        public void Join(User user)
        {
            var msg = user.Username + " Joined chat";
            user.EnterRoom(this);
            Users.Add(user);
            BroadCast("Room", msg);
        }

        public void BroadCast(string source, string msg)
        {
            Users.ForEach(user =>
            {
                if (user.Username != source)
                    user.Recieve(source, msg);
            });
        }

        public void Message(string source, string destination,string  message)
        {
            Users.FirstOrDefault(u => u.Username == destination)?.Recieve(source, message);
        }
    }
}