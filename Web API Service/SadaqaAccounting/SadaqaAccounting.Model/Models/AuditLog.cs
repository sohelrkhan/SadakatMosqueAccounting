

namespace SadaqaAccounting.Model.Models
{
    public class AuditLog : BaseEntity
    {
        public string UserId { get; set; }

        public string Action { get; set; }

        public string TableName { get; set; }

        public string RecordId { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
