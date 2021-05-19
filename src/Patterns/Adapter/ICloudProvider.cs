using System;
using Patterns.Adapter.ICloud;

namespace Patterns.Adapter
{
    public class ICloudProvider : IEmailProvider
    {
        private readonly ICloudClient icloud;

        public ICloudProvider(ICloudClient icloud) => this.icloud = icloud;
        public void DownloadEmails()
        {
            icloud.Init();
            icloud.GetEmails();
        }
    }
}