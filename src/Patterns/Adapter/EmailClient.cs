using System;
using System.Collections.Generic;

namespace Patterns.Adapter
{
    public class EmailClient
    {
        private List<IEmailProvider> providers = new List<IEmailProvider>();
        public void AddProvider(IEmailProvider provider) => providers.Add(provider);

        public void DownloadEmails()
        {
            providers.ForEach(provder => provder.DownloadEmails());
        }

    }
}