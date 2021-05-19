using System;

namespace Patterns.Mediator.Chat
{
    public static class ChatProgram
    {
        public static void Run()
        {
            var nick = new User("Nick");

            var kingPie = new User("King Pie");
            var chatRoom = new ChatRoom();
            var codeLegion = new User("Code Legion");
            var kamara = new User("Kamara");

            chatRoom.Join(nick);
            chatRoom.Join(kingPie);
            chatRoom.Join(codeLegion);
            chatRoom.Join(kamara);

            kamara.Say("Hello My name is Kamara");
            nick.Say("Hi Kamara,My name is Nicolas");
            codeLegion.Say("Hi yall");
            kamara.Say("Hi");
        }
    }
}