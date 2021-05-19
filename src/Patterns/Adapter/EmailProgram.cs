using System;

namespace Patterns.Adapter
{
    public static class EmailProgram
    {
        public static void Run()
        {
            var emailClient = new EmailClient();

            emailClient.AddProvider(new GmailProvider(new Gmail.GmailClient()));
            emailClient.AddProvider(new ICloudProvider(new ICloud.ICloudClient()));

            emailClient.DownloadEmails();
        }
    }
}