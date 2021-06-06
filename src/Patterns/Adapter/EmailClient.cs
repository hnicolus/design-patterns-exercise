using System;
using System.Collections.Generic;

namespace Patterns.Adapter
{
    public class EmailClient
    {
        private readonly List<IEmailProvider> _providers = new();
        public void AddProvider(IEmailProvider provider) => _providers.Add(provider);

        public void DownloadEmails()
        {
            _providers.ForEach(provder => provder.DownloadEmails());
        }

    }
}