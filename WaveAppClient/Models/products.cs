namespace WaveAppClient.Models
{
    public class products
    {
        /// <summary>Unique identifier for the product.</summary>
        public string id { get; }
        /// <summary>The uri of the product resource.</summary>
        public string url { get; }
        /// <summary>Name of the product.</summary>
        public string name { get; set; }
        /// <summary>Per-unit price of the product.</summary>
        public string price { get; set; }
        /// <summary>Description of the product.</summary>
        public string description { get; set; }
        /// <summary>This is set to true if you sell this product.</summary>
        public bool is_sold { get; set; }
        /// <summary>This is set to true if you buy this product.</summary>
        public bool is_bought { get; set; }
        /// <summary>If you are selling this product, this is the accounting account that you will record the income against.</summary>
        public string income_account { get; set; }
        /// <summary>If you are buying this product, this is the accounting account that you will record the expense against.</summary>
        public string expense_account { get; set; }
        /// <summary>States whether or not the product has been deleted.</summary>
        public bool active { get; }
        /// <summary>A list of sales taxes associated to the product.</summary>
        public string default_sales_taxes { get; set; }
        /// <summary>The date that the product was created.</summary>
        public string date_created { get; }
        /// <summary>The date that the product was modified.</summary>
        public string date_modified { get; }
    }
}