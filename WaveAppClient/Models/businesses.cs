namespace WaveAppClient.Models
{
    public class businesses
    {
        /// <summary>The unique identifier of the business resource.</summary>
        public string id { get; }
        /// <summary>The uri of the business resource.</summary>
        public string url { get; }
        /// <summary>The name of the business.</summary>
        public string company_name { get; set; }
        /// <summary>An object representing the primary currency for your business in Wave.</summary>
        public string primary_currency { get; }
        /// <summary>true if the current user is the owner of the business.</summary>
        public string is_owner { get; }
        /// <summary>true if the business is set as the default business for the current user.</summary>
        public string is_default_business { get; }
        /// <summary>The slug for the business group.</summary>
        public string business_group { get; }
        /// <summary>The display string for the business group.</summary>
        public string business_group_display { get; }
        /// <summary>The slug for the business type.</summary>
        public string business_type { get; }
        /// <summary>The display string for the business type.</summary>
        public string business_type_display { get; }
        /// <summary>Organization type. Can be one of corporation, partnership, or sole_proprietorship</summary>
        public string organization_type { get; }
        /// <summary>The display string for the organization type.</summary>
        public string organization_type_display { get; }
        /// <summary>Address information for the business.</summary>
        public string address_info { get; set; }
        /// <summary>Phone number for the business.</summary>
        public string phone_number { get; set; }
        /// <summary>Mobile phone number for the business.</summary>
        public string mobile_phone_number { get; set; }
        /// <summary>Toll free phone number for the business.</summary>
        public string toll_free_phone_number { get; set; }
        /// <summary>Fax number for the business.</summary>
        public string fax_number { get; set; }
        /// <summary>Website for the business.</summary>
        public string website { get; set; }
        /// <summary>The date that the business resource was created.</summary>
        public string date_created { get; }
        /// <summary>The date that the business resource was last modified.</summary>
        public string date_modified { get; }
        /// <summary>A string representing the permission scopes that the current user has on a business.</summary>
        public string scopes { get; }
    }
}