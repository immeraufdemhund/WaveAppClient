namespace WaveAppClient.Models
{
    public class geography
    {
        /// <summary>The uri of the country resource.</summary>
        public string url { get; }
        /// <summary>The name of the country.</summary>
        public string name { get; }
        /// <summary>The country code used to uniquely identify a country (in ISO 3166-1 Alpha 2 format).</summary>
        public string country_code { get; }
        /// <summary>The currency code used to uniquely identify a currency (in ISO 4217 format).</summary>
        public string currency_code { get; }
        /// <summary>The provinces of the country.</summary>
        public string provinces { get; }
    }
}