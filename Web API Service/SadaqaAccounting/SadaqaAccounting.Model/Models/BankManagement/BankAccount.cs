namespace SadaqaAccounting.Model.Models.BankManagement
{
    public class BankAccount : BaseEntity
    {
        public string BankName { get; set; }

        public string BranchName { get; set; }

        public string AccountName { get; set; }

        public string AccountNumber { get; set; }

        public decimal OpeningBalance { get; set; }
    }
}
