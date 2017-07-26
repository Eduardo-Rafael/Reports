namespace Reports
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        public int id { get; set; }

        public int? FilePro_TransactionsID { get; set; }

        public DateTime? ProcessDate { get; set; }

        [StringLength(255)]
        public string TransactionNo { get; set; }

        [StringLength(10)]
        public string TransactionNoExt { get; set; }

        public DateTime? TransactionDate { get; set; }

        public decimal? AmountReceived { get; set; }

        public decimal? AmountApplied { get; set; }

        public decimal? AmountRemaining { get; set; }

        [StringLength(10)]
        public string PaymentType { get; set; }

        [StringLength(10)]
        public string CreditCardType { get; set; }

        [StringLength(8000)]
        public string CreditCardName { get; set; }

        [StringLength(10)]
        public string CreditCardExpDate { get; set; }

        [StringLength(10)]
        public string CreditCardSecurityCode { get; set; }

        [StringLength(8000)]
        public string CreditCardAddress1 { get; set; }

        [StringLength(8000)]
        public string CreditCardAddress2 { get; set; }

        [StringLength(8000)]
        public string CreditCardAddress3 { get; set; }

        [StringLength(8000)]
        public string CreditCardAddressCity { get; set; }

        [StringLength(8000)]
        public string CreditCardAddressState { get; set; }

        [StringLength(8000)]
        public string CreditCardAddressZip { get; set; }

        [StringLength(10)]
        public string CreditCardAddressCountry { get; set; }

        [StringLength(255)]
        public string CreditCardPhone { get; set; }

        [StringLength(8000)]
        public string CheckName { get; set; }

        public DateTime? CheckDate { get; set; }

        [StringLength(255)]
        public string CheckNo { get; set; }

        [StringLength(8000)]
        public string WireName { get; set; }

        public DateTime? WireDate { get; set; }

        [StringLength(255)]
        public string WireRoutingABANo { get; set; }

        [StringLength(255)]
        public string WireAccountNo { get; set; }

        [StringLength(8000)]
        public string ECheckName { get; set; }

        public DateTime? ECheckDate { get; set; }

        [StringLength(255)]
        public string ECheckAccountType { get; set; }

        [StringLength(255)]
        public string ECheckRoutingABANo { get; set; }

        [StringLength(255)]
        public string ECheckAccountNo { get; set; }

        [StringLength(255)]
        public string ECheckCheckNo { get; set; }

        [StringLength(255)]
        public string SpectrumAccountNo { get; set; }

        public decimal? SpectrumAccountBalance { get; set; }

        [StringLength(255)]
        public string UnappliedCashAccountNo { get; set; }

        public decimal? UnappliedCashBalance { get; set; }

        [StringLength(255)]
        public string CommissionAdjustmentProducerCode { get; set; }

        public decimal? CommissionAdjustmentCommissionBalance { get; set; }

        [StringLength(8000)]
        public string PaymentReferenceDisplay { get; set; }

        [StringLength(255)]
        public string TransactionType { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        public decimal? Amount { get; set; }

        public decimal? UnappliedCashBalanceClient { get; set; }

        public decimal? ContributionAmount { get; set; }

        [StringLength(255)]
        public string PaymentMode { get; set; }

        [StringLength(10)]
        public string AdvancedPayment { get; set; }

        [StringLength(10)]
        public string NextDay { get; set; }

        [StringLength(10)]
        public string Receipt { get; set; }

        [StringLength(8000)]
        public string DisplayName { get; set; }

        [StringLength(255)]
        public string WritingProducerCode { get; set; }

        public decimal? AdjustAmount { get; set; }

        [StringLength(8000)]
        public string AdjustNote { get; set; }

        [StringLength(10)]
        public string HoldCommissions { get; set; }

        [StringLength(10)]
        public string SplitCommissions { get; set; }

        [StringLength(255)]
        public string SplitCommissionsProducer { get; set; }

        public decimal? SpectrumAccountBalanceClient { get; set; }

        [StringLength(10)]
        public string NextCycle { get; set; }

        [StringLength(10)]
        public string NewAccount { get; set; }

        public DateTime? InvestmentDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? PolicyIssueDate { get; set; }

        public DateTime? LastInvoiceDate { get; set; }

        public DateTime? PaidToDate { get; set; }

        [StringLength(10)]
        public string FutureInvestment { get; set; }

        public decimal? ApplicationFeeReceivedTemp { get; set; }

        public decimal? ApplicationFeeReceived { get; set; }

        [StringLength(10)]
        public string ApplicationFee { get; set; }

        [StringLength(10)]
        public string CommissionsNetted { get; set; }

        [StringLength(10)]
        public string PaymentModeCode { get; set; }

        public int? Duration { get; set; }

        [StringLength(10)]
        public string NettingLevel { get; set; }

        public decimal? SuspenseAmount { get; set; }

        public DateTime? SuspenseDate { get; set; }

        public decimal? CommissionAmount { get; set; }

        public decimal? CommissionPremium { get; set; }

        public decimal? CommissionAdjustment { get; set; }

        public decimal? APMCommissionOnIndexAmount { get; set; }

        public decimal? PolicyFee { get; set; }

        [StringLength(8000)]
        public string Note { get; set; }

        public DateTime? TransactionIssueDate { get; set; }

        [StringLength(255)]
        public string transactionStatus { get; set; }

        [StringLength(255)]
        public string TranType { get; set; }

        [StringLength(10)]
        public string PaypalCharge { get; set; }

        [StringLength(10)]
        public string CommissionsPaid { get; set; }

        [StringLength(255)]
        public string ProductCode { get; set; }

        public decimal? CurrentProbabilityOfSurvival { get; set; }

        public decimal? PreviousProbabilityOfSurvival { get; set; }

        [StringLength(255)]
        public string CreditCardAuthorizationCode { get; set; }

        public decimal? CreditCardFee { get; set; }

        public decimal? CreditCardTransactionFee { get; set; }

        [StringLength(255)]
        public string ProducerSentNet { get; set; }

        [StringLength(255)]
        public string SuspenseTransaction { get; set; }

        [StringLength(255)]
        public string InsuranceCompany { get; set; }

        [StringLength(10)]
        public string CountryCode { get; set; }

        [StringLength(255)]
        public string AgencyCode { get; set; }

        public int? DurationLength { get; set; }

        public decimal? GrossPremium { get; set; }

        public decimal? ContributionAmountTotal { get; set; }

        public decimal? LoyaltyBonusPercent { get; set; }

        public decimal? LoyaltyBonusAmount { get; set; }

        public decimal? AllocationBonusPercent { get; set; }

        public decimal? AllocationBonusAmount { get; set; }

        public decimal? PerPolicyChargeAmount { get; set; }

        public decimal? MutualFundChargePercent { get; set; }

        public decimal? MutualFundChargeAmount { get; set; }

        public decimal? AdministrativeChargePercent { get; set; }

        public decimal? AdministrativeChargeAmount { get; set; }

        public decimal? BankInvChargePercent { get; set; }

        public decimal? BankInvChargeAmount { get; set; }

        public decimal? SurrenderChargeFee { get; set; }

        public decimal? SurrenderChargeAmount { get; set; }

        public decimal? IndexSpreadChargePercent { get; set; }

        public decimal? NetPremium { get; set; }

        [StringLength(255)]
        public string FundCode1 { get; set; }

        public decimal? FundCode1Percent { get; set; }

        public decimal? FundCode1CurrentPrice { get; set; }

        public DateTime? FundCode1CurrentPriceDate { get; set; }

        public decimal? FundCode1PreviousPrice { get; set; }

        public DateTime? FundCode1PreviousPriceDate { get; set; }

        public decimal? FundCode1PreviousNumberOfShares { get; set; }

        public decimal? FundCode1MonthlyReturn { get; set; }

        public decimal? FundCode1NetMonthlyReturn { get; set; }

        public decimal? FundCode1InvestmentReturn { get; set; }

        public decimal? FundCode1NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode1PricePerUnitPurchased { get; set; }

        public decimal? FundCode1TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode1TotalShares { get; set; }

        public decimal? FundCode1PreviousAccountBalance { get; set; }

        public decimal? FundCode1BaseAccountBalance { get; set; }

        public decimal? FundCode1BankAdministrativeCharges { get; set; }

        public decimal? FundCode1CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode2 { get; set; }

        public decimal? FundCode2Percent { get; set; }

        public decimal? FundCode2CurrentPrice { get; set; }

        public DateTime? FundCode2CurrentPriceDate { get; set; }

        public decimal? FundCode2PreviousPrice { get; set; }

        public DateTime? FundCode2PreviousPriceDate { get; set; }

        public decimal? FundCode2PreviousNumberOfShares { get; set; }

        public decimal? FundCode2MonthlyReturn { get; set; }

        public decimal? FundCode2NetMonthlyReturn { get; set; }

        public decimal? FundCode2InvestmentReturn { get; set; }

        public decimal? FundCode2NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode2PricePerUnitPurchased { get; set; }

        public decimal? FundCode2TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode2TotalShares { get; set; }

        public decimal? FundCode2PreviousAccountBalance { get; set; }

        public decimal? FundCode2BaseAccountBalance { get; set; }

        public decimal? FundCode2BankAdministrativeCharges { get; set; }

        public decimal? FundCode2CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode3 { get; set; }

        public decimal? FundCode3Percent { get; set; }

        public decimal? FundCode3CurrentPrice { get; set; }

        public DateTime? FundCode3CurrentPriceDate { get; set; }

        public decimal? FundCode3PreviousPrice { get; set; }

        public DateTime? FundCode3PreviousPriceDate { get; set; }

        public decimal? FundCode3PreviousNumberOfShares { get; set; }

        public decimal? FundCode3MonthlyReturn { get; set; }

        public decimal? FundCode3NetMonthlyReturn { get; set; }

        public decimal? FundCode3InvestmentReturn { get; set; }

        public decimal? FundCode3NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode3PricePerUnitPurchased { get; set; }

        public decimal? FundCode3TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode3TotalShares { get; set; }

        public decimal? FundCode3PreviousAccountBalance { get; set; }

        public decimal? FundCode3BaseAccountBalance { get; set; }

        public decimal? FundCode3BankAdministrativeCharges { get; set; }

        public decimal? FundCode3CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode4 { get; set; }

        public decimal? FundCode4Percent { get; set; }

        public decimal? FundCode4CurrentPrice { get; set; }

        public DateTime? FundCode4CurrentPriceDate { get; set; }

        public decimal? FundCode4PreviousPrice { get; set; }

        public DateTime? FundCode4PreviousPriceDate { get; set; }

        public decimal? FundCode4PreviousNumberOfShares { get; set; }

        public decimal? FundCode4MonthlyReturn { get; set; }

        public decimal? FundCode4NetMonthlyReturn { get; set; }

        public decimal? FundCode4InvestmentReturn { get; set; }

        public decimal? FundCode4NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode4PricePerUnitPurchased { get; set; }

        public decimal? FundCode4TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode4TotalShares { get; set; }

        public decimal? FundCode4PreviousAccountBalance { get; set; }

        public decimal? FundCode4BaseAccountBalance { get; set; }

        public decimal? FundCode4BankAdministrativeCharges { get; set; }

        public decimal? FundCode4CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode5 { get; set; }

        public decimal? FundCode5Percent { get; set; }

        public decimal? FundCode5CurrentPrice { get; set; }

        public DateTime? FundCode5CurrentPriceDate { get; set; }

        public decimal? FundCode5PreviousPrice { get; set; }

        public DateTime? FundCode5PreviousPriceDate { get; set; }

        public decimal? FundCode5PreviousNumberOfShares { get; set; }

        public decimal? FundCode5MonthlyReturn { get; set; }

        public decimal? FundCode5NetMonthlyReturn { get; set; }

        public decimal? FundCode5InvestmentReturn { get; set; }

        public decimal? FundCode5NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode5PricePerUnitPurchased { get; set; }

        public decimal? FundCode5TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode5TotalShares { get; set; }

        public decimal? FundCode5PreviousAccountBalance { get; set; }

        public decimal? FundCode5BaseAccountBalance { get; set; }

        public decimal? FundCode5BankAdministrativeCharges { get; set; }

        public decimal? FundCode5CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode6 { get; set; }

        public decimal? FundCode6Percent { get; set; }

        public decimal? FundCode6CurrentPrice { get; set; }

        public DateTime? FundCode6CurrentPriceDate { get; set; }

        public decimal? FundCode6PreviousPrice { get; set; }

        public DateTime? FundCode6PreviousPriceDate { get; set; }

        public decimal? FundCode6PreviousNumberOfShares { get; set; }

        public decimal? FundCode6MonthlyReturn { get; set; }

        public decimal? FundCode6NetMonthlyReturn { get; set; }

        public decimal? FundCode6InvestmentReturn { get; set; }

        public decimal? FundCode6NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode6PricePerUnitPurchased { get; set; }

        public decimal? FundCode6TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode6TotalShares { get; set; }

        public decimal? FundCode6PreviousAccountBalance { get; set; }

        public decimal? FundCode6BaseAccountBalance { get; set; }

        public decimal? FundCode6BankAdministrativeCharges { get; set; }

        public decimal? FundCode6CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode7 { get; set; }

        public decimal? FundCode7Percent { get; set; }

        public decimal? FundCode7CurrentPrice { get; set; }

        public DateTime? FundCode7CurrentPriceDate { get; set; }

        public decimal? FundCode7PreviousPrice { get; set; }

        public DateTime? FundCode7PreviousPriceDate { get; set; }

        public decimal? FundCode7PreviousNumberOfShares { get; set; }

        public decimal? FundCode7MonthlyReturn { get; set; }

        public decimal? FundCode7NetMonthlyReturn { get; set; }

        public decimal? FundCode7InvestmentReturn { get; set; }

        public decimal? FundCode7NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode7PricePerUnitPurchased { get; set; }

        public decimal? FundCode7TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode7TotalShares { get; set; }

        public decimal? FundCode7PreviousAccountBalance { get; set; }

        public decimal? FundCode7BaseAccountBalance { get; set; }

        public decimal? FundCode7BankAdministrativeCharges { get; set; }

        public decimal? FundCode7CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode8 { get; set; }

        public decimal? FundCode8Percent { get; set; }

        public decimal? FundCode8CurrentPrice { get; set; }

        public DateTime? FundCode8CurrentPriceDate { get; set; }

        public decimal? FundCode8PreviousPrice { get; set; }

        public DateTime? FundCode8PreviousPriceDate { get; set; }

        public decimal? FundCode8PreviousNumberOfShares { get; set; }

        public decimal? FundCode8MonthlyReturn { get; set; }

        public decimal? FundCode8NetMonthlyReturn { get; set; }

        public decimal? FundCode8InvestmentReturn { get; set; }

        public decimal? FundCode8NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode8PricePerUnitPurchased { get; set; }

        public decimal? FundCode8TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode8TotalShares { get; set; }

        public decimal? FundCode8PreviousAccountBalance { get; set; }

        public decimal? FundCode8BaseAccountBalance { get; set; }

        public decimal? FundCode8BankAdministrativeCharges { get; set; }

        public decimal? FundCode8CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode9 { get; set; }

        public decimal? FundCode9Percent { get; set; }

        public decimal? FundCode9CurrentPrice { get; set; }

        public DateTime? FundCode9CurrentPriceDate { get; set; }

        public decimal? FundCode9PreviousPrice { get; set; }

        public DateTime? FundCode9PreviousPriceDate { get; set; }

        public decimal? FundCode9PreviousNumberOfShares { get; set; }

        public decimal? FundCode9MonthlyReturn { get; set; }

        public decimal? FundCode9NetMonthlyReturn { get; set; }

        public decimal? FundCode9InvestmentReturn { get; set; }

        public decimal? FundCode9NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode9PricePerUnitPurchased { get; set; }

        public decimal? FundCode9TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode9TotalShares { get; set; }

        public decimal? FundCode9PreviousAccountBalance { get; set; }

        public decimal? FundCode9BaseAccountBalance { get; set; }

        public decimal? FundCode9BankAdministrativeCharges { get; set; }

        public decimal? FundCode9CurrentValue { get; set; }

        [StringLength(255)]
        public string FundCode10 { get; set; }

        public decimal? FundCode10Percent { get; set; }

        public decimal? FundCode10CurrentPrice { get; set; }

        public DateTime? FundCode10CurrentPriceDate { get; set; }

        public decimal? FundCode10PreviousPrice { get; set; }

        public DateTime? FundCode10PreviousPriceDate { get; set; }

        public decimal? FundCode10PreviousNumberOfShares { get; set; }

        public decimal? FundCode10MonthlyReturn { get; set; }

        public decimal? FundCode10NetMonthlyReturn { get; set; }

        public decimal? FundCode10InvestmentReturn { get; set; }

        public decimal? FundCode10NumberOfUnitsPurchased { get; set; }

        public decimal? FundCode10PricePerUnitPurchased { get; set; }

        public decimal? FundCode10TotalPriceOfUnitsPurchased { get; set; }

        public decimal? FundCode10TotalShares { get; set; }

        public decimal? FundCode10PreviousAccountBalance { get; set; }

        public decimal? FundCode10BaseAccountBalance { get; set; }

        public decimal? FundCode10BankAdministrativeCharges { get; set; }

        public decimal? FundCode10CurrentValue { get; set; }

        public decimal? TotalFees { get; set; }

        public decimal? InvestmentResults { get; set; }

        public decimal? PreviousFundValue { get; set; }

        public decimal? CurrentFundValue { get; set; }

        public decimal? PreviousCashValue { get; set; }

        public decimal? CurrentCashValue { get; set; }

        public decimal? PreviousReserve { get; set; }

        public decimal? CurrentReserve { get; set; }

        public decimal? TotalCurrentShares { get; set; }

        public decimal? TotalShares { get; set; }

        [StringLength(255)]
        public string Producer0Code { get; set; }

        [StringLength(8000)]
        public string Producer0DisplayName { get; set; }

        public decimal? Producer0CommissionPercent { get; set; }

        public decimal? Producer0CommissionAmount { get; set; }

        public decimal? Producer0CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer1Code { get; set; }

        [StringLength(8000)]
        public string Producer1DisplayName { get; set; }

        public decimal? Producer1CommissionPercent { get; set; }

        public decimal? Producer1CommissionAmount { get; set; }

        public decimal? Producer1CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer2Code { get; set; }

        [StringLength(8000)]
        public string Producer2DisplayName { get; set; }

        public decimal? Producer2CommissionPercent { get; set; }

        public decimal? Producer2CommissionAmount { get; set; }

        public decimal? Producer2CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer3Code { get; set; }

        [StringLength(8000)]
        public string Producer3DisplayName { get; set; }

        public decimal? Producer3CommissionPercent { get; set; }

        public decimal? Producer3CommissionAmount { get; set; }

        public decimal? Producer3CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer4Code { get; set; }

        [StringLength(8000)]
        public string Producer4DisplayName { get; set; }

        public decimal? Producer4CommissionPercent { get; set; }

        public decimal? Producer4CommissionAmount { get; set; }

        public decimal? Producer4CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer5Code { get; set; }

        [StringLength(8000)]
        public string Producer5DisplayName { get; set; }

        public decimal? Producer5CommissionPercent { get; set; }

        public decimal? Producer5CommissionAmount { get; set; }

        public decimal? Producer5CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer6Code { get; set; }

        [StringLength(8000)]
        public string Producer6DisplayName { get; set; }

        public decimal? Producer6CommissionPercent { get; set; }

        public decimal? Producer6CommissionAmount { get; set; }

        public decimal? Producer6CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer7Code { get; set; }

        [StringLength(8000)]
        public string Producer7DisplayName { get; set; }

        public decimal? Producer7CommissionPercent { get; set; }

        public decimal? Producer7CommissionAmount { get; set; }

        public decimal? Producer7CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer8Code { get; set; }

        [StringLength(8000)]
        public string Producer8DisplayName { get; set; }

        public decimal? Producer8CommissionPercent { get; set; }

        public decimal? Producer8CommissionAmount { get; set; }

        public decimal? Producer8CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer9Code { get; set; }

        [StringLength(8000)]
        public string Producer9DisplayName { get; set; }

        public decimal? Producer9CommissionPercent { get; set; }

        public decimal? Producer9CommissionAmount { get; set; }

        public decimal? Producer9CommissionAdjustment { get; set; }

        [StringLength(255)]
        public string Producer10Code { get; set; }

        [StringLength(8000)]
        public string Producer10DisplayName { get; set; }

        public decimal? Producer10CommissionPercent { get; set; }

        public decimal? Producer10CommissionAmount { get; set; }

        public decimal? Producer10CommissionAdjustment { get; set; }

        [StringLength(10)]
        public string Reverse { get; set; }

        [StringLength(8000)]
        public string CustodialBankCode { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [MaxLength(100)]
        public byte[] CreditCardNumberEncrypted { get; set; }

        public DateTime? inserted { get; set; }

        [StringLength(100)]
        public string inputsource { get; set; }

        [StringLength(50)]
        public string DocumentType { get; set; }

        public int? CurrencyId { get; set; }
    }
}
