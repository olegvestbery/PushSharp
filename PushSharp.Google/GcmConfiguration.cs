using System;

namespace PushSharp.Google
{
    public class GcmConfiguration
    {
        private const string GCM_SEND_URL = "https://gcm-http.googleapis.com/gcm/send";

        public GcmConfiguration (string senderAuthToken)
        {
            this.SenderAuthToken = senderAuthToken;
            this.GcmUrl = GCM_SEND_URL;

            this.ValidateServerCertificate = false;
        }

        public GcmConfiguration (string optionalSenderID, string senderAuthToken, string optionalApplicationIdPackageName)
        {
            this.SenderID = optionalSenderID;
            this.SenderAuthToken = senderAuthToken;
            this.ApplicationIdPackageName = optionalApplicationIdPackageName;
            this.GcmUrl = GCM_SEND_URL;

            this.ValidateServerCertificate = false;
        }

        public GcmConfiguration(string optionalSenderID, string senderAuthToken, string optionalApplicationIdPackageName, string gcmUrl)
        {
            this.SenderID = optionalSenderID;
            this.SenderAuthToken = senderAuthToken;
            this.ApplicationIdPackageName = optionalApplicationIdPackageName;
            this.GcmUrl = gcmUrl;
            this.Timeout = new TimeSpan(0,1,30);

            this.ValidateServerCertificate = false;
        }

        public string SenderID { get; private set; }

        public string SenderAuthToken { get; private set; }

        public string ApplicationIdPackageName { get; private set; }

        public bool ValidateServerCertificate { get; set; }

        public string GcmUrl { get; set; }

        public TimeSpan Timeout { get; set; }

        public void OverrideUrl (string url)
        {
            GcmUrl = url;
        }
        public void OvverideTimeout(TimeSpan to)
        {
            Timeout = to;
        }
    }
}

