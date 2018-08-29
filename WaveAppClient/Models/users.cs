namespace WaveAppClient.Models
{
    public class users
    {
        /// <summary>The unique id used to identify the user.</summary>
        public string id { get; }
        /// <summary>URL that points to the current user resource.</summary>
        public string url { get; }
        /// <summary>The user’s first name.</summary>
        public string first_name { get; set; }
        /// <summary>The user’s last name.</summary>
        public string last_name { get; set; }
        /// <summary>The list of emails associated with this user.</summary>
        public string emails { get; }
        /// <summary>List of businesses that belong to this user.</summary>
        public string businesses { get; }
        /// <summary>The date that the user was created (in ISO 8601).</summary>
        public string date_created { get; }
        /// <summary>The date that the user was last modified (in ISO 8601).</summary>
        public string date_modified { get; }
        /// <summary>The date that the user last logged into Wave (in ISO 8601).</summary>
        public string last_login { get; }
    }
}
