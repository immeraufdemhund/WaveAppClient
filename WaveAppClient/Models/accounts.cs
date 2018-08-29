namespace WaveAppClient.Models
{
    public class accounts
    {
        /// <summary>Primary identifier of the account.</summary>
        public int id { get; }
        /// <summary>The uri of the account resource.</summary>
        public string url { get; }
        /// <summary>The name of the account.</summary>
        public string name { get; set; }
        /// <summary>States whether or not the account has been deleted.</summary>
        public bool active { get; }
        /// <summary>The type of the account. Can be one of: “asset”, “income”,
        /// “expense”, “liability” or “equity”.</summary>
        public string account_type { get; }
        /// <summary>States if this account is a system account and which one. Can be one of:
        /// “accounts_receivable”, “sales_tax_receivable”, “owner_equity”
        /// “unrealized_gain_on_foreign_currency”, “gain_on_foreign_exchange”,
        /// “accounts_payable”, “sales_tax_payable”, “retained_earnings”,
        /// “unrealized_loss_on_foreign_currency”, “loss_on_foreign_exchange”,
        /// “shareholder_loan”, “owner_investment_draw”, “uncategorized_income”
        /// “uncategorized_expense” or null.</summary>
        public string system_account { get; }
        /// <summary>The id of the account template used for the account.</summary>
        public int account_template_id { get; }
        /// <summary>States whether the account is a payment account.</summary>
        public bool is_payment { get; set; }
        /// <summary>States whether the account can be deleted.</summary>
        public bool can_delete { get; }
        /// <summary>The currency of the account.</summary>
        public string currency { get; set; }
        /// <summary>States whether the account currency can be modified.</summary>
        public bool is_currency_editable { get; }
        /// <summary>States whether the account name can be modified.</summary>
        public bool is_name_editable { get; }
        /// <summary>States whether the account can be used as a payment account.</summary>
        public bool is_payment_editable { get; }
        /// <summary>The date the account was created (in ISO 8601).</summary>
        public string date_created { get; }
        /// <summary>The date the account was last modified (in ISO 8601).</summary>
        public string date_modified { get; }
    }
}
