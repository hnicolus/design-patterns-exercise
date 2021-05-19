using System;
using Patterns.Adapter.Gmail;

namespace Patterns.Adapter
{
    public class GmailProvider : IEmailProvider
    {
        private readonly GmailClient gmailClient;

        public GmailProvider(GmailClient gmailClient) =>this.gmailClient = gmailClient;
        public void DownloadEmails()
        {
            gmailClient.connect();
            gmailClient.getEmails();
            gmailClient.disconnect();
        }
    }
}