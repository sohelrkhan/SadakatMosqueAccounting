namespace SadaqaAccounting.Model.Models
{
    public class ReceiptBook : BaseEntity
    {
        public string BookNo { get; set; }

        public int StartNumber { get; set; }

        public int EndNumber { get; set; }

        public bool IsAssigned { get; set; }
    }
}
