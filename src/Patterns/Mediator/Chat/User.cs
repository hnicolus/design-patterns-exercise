using System.Collections.Generic;
using static System.Console;
namespace Patterns.Mediator.Chat
{
    public class User
    {
        private ChatRoom room;
        public string Username { get; set; }
        private List<string> ChatMessages = new List<string>();
        public User(string username)=> Username = username;

        public void Say(string message)=> room.BroadCast(Username, message);

        public void PrivateMessage(string to, string message)=> room.Message(Username, to, message);

        public void EnterRoom(ChatRoom room) => this.room = room;
        public void Recieve(string sender, string message)
        {
            var txt = $"{sender}: {message}";
            ChatMessages.Add(txt);
            WriteLine($"[{Username}'s chat session] {txt}");
        }

    }
}