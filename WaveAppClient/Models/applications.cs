namespace WaveAppClient.Models
{
    public class applications
    {
        /// <summary>URL that points to the current application.</summary>
        public string url { get; }
        /// <summary>The application’s display name.</summary>
        public string name { get; }
        /// <summary>The application’s public oauth2 client_id.</summary>
        public string client_id { get; }
        /// <summary>The date the application was created (in ISO 8601).</summary>
        public string date_created { get; }
        /// <summary>The date the application was last modified (in ISO 8601).</summary>
        public string date_modified { get; }
        /// <summary>The application’s webhook URL.</summary>
        public string hook_url { get; }
        /// <summary>A field to store any additional data for the application.</summary>
        public string extra_data { get; }
    }
}