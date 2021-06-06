using System;
using Patterns.Adapter.Gmail;

namespace Patterns.Adapter
{
    public class GmailProvider : IEmailProvider
    {
        private readonly GmailClient _gmailClient;

        public GmailProvider(GmailClient gmailClient) => this._gmailClient = gmailClient;
        public void DownloadEmails()
        {
            GmailClient.Connect();
            GmailClient.GetEmails();
            GmailClient.Disconnect();
        }
    }
}