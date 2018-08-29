namespace WaveAppClient.Models
{
    public class sales_taxes
    {
        /// <summary>Primary identifier of the sales tax.</summary>
        public int id { get; }
        /// <summary>The uri of the sales tax resource.</summary>
        public int url { get; }
        /// <summary>The name of the sales tax resource.</summary>
        public string name { get; set; }
        /// <summary>The abbreviation for the sales tax resource.</summary>
        public string abbreviation { get; set; }
        /// <summary>The description for the sales tax resource.</summary>
        public string description { get; }
        /// <summary>The list of tax rate objects associated with the sales tax resource.</summary>
        public string tax_rates { get; set; }
        /// <summary>The tax number representation of this tax.</summary>
        public string tax_number { get; set; }
        /// <summary>Flag to specify whether a tax has been archived (deleted).</summary>
        public bool archived { get; }
        /// <summary>Flag to specify whether a tax is compound.</summary>
        public bool is_compound { get; set; }
        /// <summary>Flag to specify whether a tax is recoverable.</summary>
        public bool is_recoverable { get; set; }
        /// <summary>Flag to specify whether the tax number is shown on invoices.</summary>
        public bool show_tax_num_on_invoices { get; set; }
        /// <summary>The accounts receivable object associated with this sales tax.</summary>
        public string accounts_receivable { get; }
        /// <summary>The accounts payable object associated with this sales tax.</summary>
        public string accounts_payable { get; }
        /// <summary>The date that the sales tax resource was created.</summary>
        public string date_created { get; }
        /// <summary>The date that the sales tax resource was last modified.</summary>
        public string date_modified { get; }
        /// <summary>The sales tax rate on today’s date.</summary>
        public int current_rate { get; }
    }
}
