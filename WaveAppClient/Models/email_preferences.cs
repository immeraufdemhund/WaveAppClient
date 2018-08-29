namespace WaveAppClient.Models
{
    public class email_preferences
    {
        /// <summary>The primary identifier of the email preference.</summary>
        public string email_type_slug { get; }
        /// <summary>The display name of the email preference.</summary>
        public string email_type_display { get; }
        /// <summary>A helpful description for the email preference.</summary>
        public string email_type_description { get; }
        /// <summary>true if the current user is subscribed to the email preference, false otherwise.</summary>
        public bool subscribed { get; set; }
    }
}