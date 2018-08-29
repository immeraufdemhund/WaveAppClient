namespace WaveAppClient.Models
{
    public class currencies
    {
        /// <summary>The uri of the currency resource.</summary>
        public string url { get; }
        /// <summary>The currency code used to uniquely identify a currency (in ISO 4217 format).</summary>
        public string code { get; }
        /// <summary>The symbol for the currency.</summary>
        public string symbol { get; }
        /// <summary>The name of the currency.</summary>
        public string name { get; }
    }
}