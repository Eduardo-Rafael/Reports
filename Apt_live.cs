namespace Reports
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Apt_live : DbContext
    {
        public Apt_live()
            : base("name=Apt_live")
        {
        }

        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<ProducersPaymentMethod> ProducersPaymentMethods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producer>()
                .Property(e => e.MasterProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.ProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Territory)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.ProducerType)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.RecommendingProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.AgencyName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.TitleName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.IDNo)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessAddress3)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessCity)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessState)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessZip)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BusinessCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.ShipTo)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.ShipToOtherProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingAddress3)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingCity)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingState)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingZip)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.MailingCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PhoneType1)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Phone1)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PhoneType2)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PhoneType3)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Phone3)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PhoneType4)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Phone4)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PhoneType5)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Phone5)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PhoneType6)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Phone6)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Email3)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.AgencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.SpectrumAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PayThruProducer)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.PayThruProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountAddress3)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountCity)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountState)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountZip)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankAccountCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.HoldCommissions)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.CheckName)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.IsLatinAmericaProducer)
                .IsUnicode(false);

            modelBuilder.Entity<Producer>()
                .Property(e => e.ReferredBy)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionNoExt)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardType)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardSecurityCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddress3)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddressCity)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddressState)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddressZip)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAddressCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CheckName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.WireName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.WireRoutingABANo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.WireAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ECheckName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ECheckAccountType)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ECheckRoutingABANo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ECheckAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ECheckCheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.SpectrumAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.UnappliedCashAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CommissionAdjustmentProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PaymentReferenceDisplay)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionType)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AdvancedPayment)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.NextDay)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Receipt)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.WritingProducerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AdjustNote)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.HoldCommissions)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.SplitCommissions)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.SplitCommissionsProducer)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.NextCycle)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.NewAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FutureInvestment)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ApplicationFee)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CommissionsNetted)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PaymentModeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.NettingLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.transactionStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PaypalCharge)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CommissionsPaid)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CurrentProbabilityOfSurvival)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PreviousProbabilityOfSurvival)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CreditCardAuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ProducerSentNet)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.SuspenseTransaction)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.InsuranceCompany)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AgencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.LoyaltyBonusPercent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AllocationBonusPercent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.MutualFundChargePercent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AdministrativeChargePercent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.BankInvChargePercent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.SurrenderChargeFee)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.IndexSpreadChargePercent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode1CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode2CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode3CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode4CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode5CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode6CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode7CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode8CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode9CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10Percent)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10CurrentPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10PreviousPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10PreviousNumberOfShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10MonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10NetMonthlyReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10InvestmentReturn)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10NumberOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10PricePerUnitPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10TotalPriceOfUnitsPurchased)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10PreviousAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10BaseAccountBalance)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10BankAdministrativeCharges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.FundCode10CurrentValue)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TotalCurrentShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TotalShares)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer0Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer0DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer1Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer1DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer2Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer2DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer3Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer3DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer4Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer4DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer5Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer5DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer6Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer6DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer7Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer7DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer8Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer8DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer9Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer9DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer10Code)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Producer10DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Reverse)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CustodialBankCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.inputsource)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);
        }
    }
}
