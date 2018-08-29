namespace WaveAppClient.Models
{
    public class invoices
    {
        /// <summary>Primary identifier of the invoice.</summary>
        public int id { get; }
        /// <summary>The uri of the invoice resource.</summary>
        public string url { get; }
        /// <summary>The customer associated to the invoice.</summary>
        public string customer { get; set; }
        /// <summary>The date of the invoice (in ISO 8601).</summary>
        public string invoice_date { get; set; }
        /// <summary>The invoice number of the invoice.</summary>
        public string invoice_number { get; set; }
        /// <summary>The label of the invoice number.</summary>
        public string invoice_number_label { get; set; }
        /// <summary>The currency of the invoice.</summary>
        public string invoice_currency { get; set; }
        /// <summary>The total of the invoice.</summary>
        public int invoice_total { get; }
        /// <summary>The total amount of taxes of the invoice.</summary>
        public int invoice_tax_total { get; }
        /// <summary>The amount paid of the invoice.</summary>
        public int invoice_amount_paid { get; }
        /// <summary>The remaining outstanding balance of the invoice.</summary>
        public int invoice_amount_due { get; }
        /// <summary>The status of the invoice. Can be set to either "draft" or "saved".</summary>
        public string status { get; set; }
        /// <summary>Controls whether credit card payments are enabled for the invoice.</summary>
        public bool disable_credit_card_payments { get; set; }
        /// <summary>Controls whether bank transfer payments are enabled for the invoice.</summary>
        public bool disable_bank_payments { get; set; }
        /// <summary>The uri for the read only invoice view of the invoice.</summary>
        public string readonly_url { get; }
        /// <summary>The uri of the PDF version of the invoice.</summary>
        public string pdf_url { get; }
        /// <summary>The uri of the invoice items resource.</summary>
        public string items_url { get; }
        /// <summary>The uri of the invoice payments resource.</summary>
        public string payments_url { get; }
        /// <summary>A list of invoice items associated to the invoice. Only visible on the invoice detail response</summary>
        public string items { get; set; }
        /// <summary>A list of payments made against the invoice. Only visible on the invoice detail response</summary>
        public string payments { get; set; }
        /// <summary>The due date of the invoice (in ISO 8601).</summary>
        public string due_date { get; set; }
        /// <summary>The subheading of the invoice.</summary>
        public string subhead { get; set; }
        /// <summary>The footer of the invoice.</summary>
        public string footer { get; set; }
        /// <summary>Sales order from the invoice or purchase order number from the associated bill.</summary>
        public string po_so_number { get; set; }
        /// <summary>Additional notes for the invoice.</summary>
        public string memo { get; set; }
        /// <summary>The address associated to this invoice.</summary>
        public string address { get; }
        /// <summary>Exchange rate for the invoice.</summary>
        public int exchange_rate { get; set; }
        /// <summary>Date the last time the invoice was sent by email (in ISO 8601).</summary>
        public string last_sent { get; }
        /// <summary>Date the invoice was created (in ISO 8601).</summary>
        public string date_created { get; }
        /// <summary>Date the invoice was last modified (in ISO 8601).</summary>
        public string date_modified { get; }
        /// <summary>Default item title.</summary>
        public string item_title { get; set; }
        /// <summary>Default description title.</summary>
        public string description_title { get; set; }
        /// <summary>Default quantity title.</summary>
        public string quantity_title { get; set; }
        /// <summary>Default price title.</summary>
        public string price_title { get; set; }
        /// <summary>Default amount title.</summary>
        public string amount_title { get; set; }
        /// <summary>States whether item column is hidden.</summary>
        public bool hide_item { get; set; }
        /// <summary>States whether description column is hidden.</summary>
        public bool hide_description { get; set; }
        /// <summary>States whether quantity column is hidden.</summary>
        public bool hide_quantity { get; set; }
        /// <summary>States whether price column is hidden.</summary>
        public bool hide_price { get; set; }
        /// <summary>States whether amount column is hidden.</summary>
        public bool hide_amount { get; set; }
        /// <summary>Date of the most recent invoice payment (in ISO 8601).</summary>
        public string last_payment_date { get; }
    }
}