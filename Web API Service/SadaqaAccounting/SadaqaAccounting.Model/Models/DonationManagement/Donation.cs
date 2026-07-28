using SadaqaAccounting.Model.Models.BankManagement;

namespace SadaqaAccounting.Model.Models.DonationManagement
{
    public class Donation : BaseEntity
    {
        public string ReceiptNo { get; set; }

        public DateTime DonationDate { get; set; }

        public int DonorId { get; set; }

        public Donor Donor { get; set; }

        public int DonationCategoryId { get; set; }

        public DonationCategory DonationCategory { get; set; }

        public decimal Amount { get; set; }

        public int PaymentMethodId { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public int? BankAccountId { get; set; }

        public BankAccount BankAccount { get; set; }

        public string ReferenceNo { get; set; }

        public string Remarks { get; set; }
    }
}
