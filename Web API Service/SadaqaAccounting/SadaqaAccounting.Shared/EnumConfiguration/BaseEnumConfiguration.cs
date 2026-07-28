namespace SadaqaAccounting.Shared.EnumConfiguration
{
    public static class BaseEnumConfiguration
    {
        public static class SadaqaAccounting
        {
            public readonly static int GlobalStatus = 1;
            public readonly static int ApplicationUserType = 2;
            public readonly static int PaymentMode = 3;
            public readonly static int TransactionType = 4;
            public readonly static int SourceType = 5;
            public readonly static int Month = 6;
            public readonly static int DonationCategory = 7;
            public readonly static int PaymentMethod = 8;
            public readonly static int ExpenseCategory = 9;
        }
    }

    public static class BaseEnumCollection
    {
        public static class GlobalStatus
        {
            public readonly static int Active = 1;
            public readonly static int Inactive = 2;
            public readonly static int Disposed = 3;
        }

        public static class ApplicationUserType
        {
            public readonly static int Admin = 4;
            public readonly static int Employee = 5;
        }
        
        public static class PaymentMode
        {
            public readonly static int Cash = 6;
            public readonly static int Bank = 7;
        }
        
        public static class TransactionType
        {
            public readonly static int In = 8;
            public readonly static int Out = 9;
        }

        public static class SourceType
        {
            public readonly static int Income = 10;
            public readonly static int Expense = 11;
        }

        public static class Month
        {
            public readonly static int January = 12;
            public readonly static int February = 13;
            public readonly static int March = 14;
            public readonly static int April = 15;
            public readonly static int May = 16;
            public readonly static int June = 17;
            public readonly static int July = 18;
            public readonly static int August = 19;
            public readonly static int September = 20;
            public readonly static int Octobor = 21;
            public readonly static int November = 22;
            public readonly static int December = 23;
        }

        public static class DonationCategory
        {
            public readonly static int MonthlyDonation = 31;
            public readonly static int Zakat = 32;
            public readonly static int Sadaqah = 33;
            public readonly static int Fitra = 34;
            public readonly static int Qurbani = 35;
            public readonly static int MosqueConstruction = 36;
            public readonly static int Madrasa = 37;
            public readonly static int GeneralDonation = 38;
            public readonly static int Waqf = 39;
            public readonly static int OtherDonation = 40;
        }

        public static class PaymentMethod
        {
            public readonly static int Cash = 51;
            public readonly static int Bank = 52;
            public readonly static int Bkash = 53;
            public readonly static int Nagad = 54;
            public readonly static int Rocket = 55;
            public readonly static int Cheque = 56;
            public readonly static int SSLCommerze = 57;
            public readonly static int Other = 58;
        }

        public static class ExpenseCategoryEnum
        {
            public readonly static int ImamSalary = 61;
            public readonly static int MuazzinSalary = 62;
            public readonly static int Electricity = 63;
            public readonly static int Gas = 64;
            public readonly static int Water = 65;
            public readonly static int Maintenance = 66;
            public readonly static int Cleaning = 67;
            public readonly static int Food = 68;
            public readonly static int MadrasaExpense = 69;
            public readonly static int Construction = 70;
            public readonly static int Other = 71;
        }
    }
}