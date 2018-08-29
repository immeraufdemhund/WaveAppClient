namespace WaveAppClient.Models
{
    public class receipts
    {
        /// <summary>The unique identifier for a receipt.</summary>
        public string id { get; }
        /// <summary>Name of the merchant associated with the receipt.</summary>
        public string merchant { get; set; }
        /// <summary>Transaction date of the receipt.</summary>
        public string date { get; set; }
        /// <summary>Subtotal of the receipt with 2 decimal places.</summary>
        public string subtotal { get; set; }
        /// <summary>Total amount of the receipt with 2 decimal places.</summary>
        public string total { get; set; }
        /// <summary>3 letter ISO currency code.</summary>
        public string currency_code { get; set; }
        /// <summary>ID of the category associated with the receipt.</summary>
        public string account_pk { get; set; }
        /// <summary>ID of the payment account associated with the receipt.</summary>
        public string payment_account_pk { get; set; }
        /// <summary>Additional note associated with the receipt.</summary>
        public string note { get; set; }
        /// <summary>Time when the receipt was submitted.</summary>
        public string submitted_at { get; }
        /// <summary>Time when the receipt was last modified.</summary>
        public string modified_at { get; set; }
        /// <summary>“standard” or “bill”.</summary>
        public string receipt_type { get; set; }
        /// <summary>One of “web”, “email”, “api” and “unknown”.</summary>
        public string source { get; }
        /// <summary>One of “Draft”, “Processing”, “Processed” and “Verified”.</summary>
        public string status { get; }
        /// <summary>A list of tax items associated with the receipt.</summary>
        public string taxes { get; }
        /// <summary>A list of iamges.</summary>
        public string images { get; }
    }
}