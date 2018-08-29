namespace WaveAppClient.Models
{
    public class customers
    {
        /// <summary>The unique identifier for a customer.</summary>
        public string id { get; }
        /// <summary>The uri of the customer resource.</summary>
        public string url { get; }
        /// <summary>Custom account number you can use to identify the customer (perhaps to another system you use).</summary>
        public string account_number { get; set; }
        /// <summary>States whether or not the customer has been deleted.</summary>
        public bool active { get; }
        /// <summary>The full name of the customer (company name, or display name).</summary>
        public string name { get; set; }
        /// <summary>Customers first name.</summary>
        public string first_name { get; set; }
        /// <summary>Customers last name.</summary>
        public string last_name { get; set; }
        /// <summary>Email for the customer.</summary>
        public string email { get; set; }
        /// <summary>Fax number for the customer.</summary>
        public string fax_number { get; set; }
        /// <summary>Mobile number for the customer.</summary>
        public string mobile_number { get; set; }
        /// <summary>Phone number for the customer.</summary>
        public string phone_number { get; set; }
        /// <summary>Toll-free number for the customer.</summary>
        public string toll_free_number { get; set; }
        /// <summary>Website for the customer.</summary>
        public string website { get; set; }
        /// <summary>Embedded currency object set to the customer’s preferred currency.</summary>
        public string currency { get; }
        /// <summary>Address for the customer.</summary>
        public string address { get; set; }
        /// <summary>Optional shipping details for the customer.</summary>
        public string shipping_details { get; set; }
        /// <summary>The date the customer was created.</summary>
        public string date_created { get; }
        /// <summary>The date the customer was last modified.</summary>
        public string date_modified { get; }
    }
}