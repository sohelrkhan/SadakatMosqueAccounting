namespace SadaqaAccounting.Application.ApplicationLogic.MasterSettings.EnumLogic.Command
{
    public class CreateEnumSeedCommand
    {
        private IEnumTypeRepository _enumTypeRepository;
        private IEnumTypeCollectionRepository _enumTypeCollectionRepository;
        private IMapper _mapper;

        public CreateEnumSeedCommand(IEnumTypeRepository enumTypeRepository, IMapper mapper, IEnumTypeCollectionRepository enumTypeCollectionRepository)
        {
            _enumTypeRepository = enumTypeRepository;
            _mapper = mapper;
            _enumTypeCollectionRepository = enumTypeCollectionRepository;
        }

        public async Task SeedAsync()
        {
            // Get newly Enum Type and Enum Type Collection
            var enumTypes = CreateEnumTypes();
            var entmTypeCollections = CreateEnumTypeCollections();

            // For Enum Type
            foreach (var enumType in enumTypes)
            {
                // Check enum is exist or not
                var isEnumTypeExit = await _enumTypeRepository.GetByIdAsync(enumType.Id);

                if (isEnumTypeExit == null)
                {
                    var newEnumType = _mapper.Map<EnumType>(enumType);
                    await _enumTypeRepository.CreateAsync(newEnumType);
                }
            }

            // For feature
            foreach (var enumTypeCollection in entmTypeCollections)
            {
                // Check enum type collection is exist or not
                var isEnumTypeCollectionExit = await _enumTypeCollectionRepository.GetByIdAsync(enumTypeCollection.Id);

                if (isEnumTypeCollectionExit == null)
                {
                    var newEnumTypeCollection = _mapper.Map<EnumTypeCollection>(enumTypeCollection);
                    await _enumTypeCollectionRepository.CreateAsync(newEnumTypeCollection);
                }
            }
        }

        // Create seed Enum Type
        private ICollection<EnumType> CreateEnumTypes()
        {
            return new List<EnumType>()
            {
                new EnumType { Id = 1, Name = "Global Status" },
                new EnumType { Id = 2, Name = "Application User Type" },
                new EnumType { Id = 3, Name = "Payment Mode" },
                new EnumType { Id = 4, Name = "Transaction Type" },
                new EnumType { Id = 5, Name = "Source Type" },
                new EnumType { Id = 6, Name = "Month" },
                new EnumType { Id = 7, Name = "Donation Category" },
                new EnumType { Id = 8, Name = "Payment Method" },
                new EnumType { Id = 9, Name = "Expense Category Enum" },
            };
        }

        // Create seed Enum Type Collection
        private ICollection<EnumTypeCollection> CreateEnumTypeCollections()
        {
            return new List<EnumTypeCollection>()
            {
                new EnumTypeCollection { Id = 1, Name = "Active", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.GlobalStatus },
                new EnumTypeCollection { Id = 2, Name = "Inactive", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.GlobalStatus },
                new EnumTypeCollection { Id = 3, Name = "Disposed", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.GlobalStatus },

                new EnumTypeCollection { Id = 4, Name = "Admin", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.ApplicationUserType },
                new EnumTypeCollection { Id = 5, Name = "Employee", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.ApplicationUserType },
                
                new EnumTypeCollection { Id = 6, Name = "Cash", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMode },
                new EnumTypeCollection { Id = 7, Name = "Bank", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMode },
                
                new EnumTypeCollection { Id = 8, Name = "In", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.TransactionType },
                new EnumTypeCollection { Id = 9, Name = "Out", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.TransactionType },

                new EnumTypeCollection { Id = 10, Name = "Income", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.SourceType },
                new EnumTypeCollection { Id = 11, Name = "Expense", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.SourceType },

                new EnumTypeCollection { Id = 12, Name = "Jamuary", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 13, Name = "February", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 14, Name = "March", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 15, Name = "April", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 16, Name = "May", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 17, Name = "June", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 18, Name = "July", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 19, Name = "August", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 20, Name = "September", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 21, Name = "October", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 22, Name = "November", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },
                new EnumTypeCollection { Id = 23, Name = "December", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.Month },

                new EnumTypeCollection { Id = 31, Name = "MonthlyDonation", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 32, Name = "Zakat", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 33, Name = "Sadaqah", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 34, Name = "Fitra", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 35, Name = "Qurbani", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 36, Name = "Mosque Construction", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 37, Name = "Madrasa", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 38, Name = "General Donation", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 39, Name = "Waqf", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },
                new EnumTypeCollection { Id = 40, Name = "OtherDonation", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.DonationCategory },

                new EnumTypeCollection { Id = 51, Name = "Cash", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 52, Name = "Bank", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 53, Name = "Bkash", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 54, Name = "Nagad", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 55, Name = "Rocket", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 56, Name = "Cheque", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 57, Name = "SSLCommerze", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },
                new EnumTypeCollection { Id = 58, Name = "Other", EnumTypeId = BaseEnumConfiguration.SadaqaAccounting.PaymentMethod },

            };
        }
    }
}