using System;

namespace Patterns.Facade
{
    public static class FacadeFirstProgram
    {
        public static void Run()
        {
            var notificationService = new NotificationService();
            notificationService.Send("Hello world", "127.0.0.1");
        }
    }
}