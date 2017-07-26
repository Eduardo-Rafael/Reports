namespace Reports
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Producer
    {
        public int id { get; set; }

        [StringLength(255)]
        public string MasterProducerCode { get; set; }

        [StringLength(255)]
        public string ProducerCode { get; set; }

        [StringLength(10)]
        public string Territory { get; set; }

        [StringLength(255)]
        public string ProducerType { get; set; }

        [StringLength(255)]
        public string RecommendingProducerCode { get; set; }

        public int? ProducerLevel { get; set; }

        [StringLength(8000)]
        public string AgencyName { get; set; }

        [StringLength(255)]
        public string TitleName { get; set; }

        [StringLength(8000)]
        public string FirstName { get; set; }

        [StringLength(8000)]
        public string MiddleName { get; set; }

        [StringLength(8000)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Suffix { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(8000)]
        public string IDNo { get; set; }

        [StringLength(8000)]
        public string DisplayName { get; set; }

        [StringLength(8000)]
        public string BusinessAddress1 { get; set; }

        [StringLength(8000)]
        public string BusinessAddress2 { get; set; }

        [StringLength(8000)]
        public string BusinessAddress3 { get; set; }

        [StringLength(8000)]
        public string BusinessCity { get; set; }

        [StringLength(8000)]
        public string BusinessState { get; set; }

        [StringLength(255)]
        public string BusinessZip { get; set; }

        [StringLength(20)]
        public string BusinessCountry { get; set; }

        [StringLength(255)]
        public string ShipTo { get; set; }

        [StringLength(255)]
        public string ShipToOtherProducerCode { get; set; }

        [StringLength(8000)]
        public string MailingAddress1 { get; set; }

        [StringLength(8000)]
        public string MailingAddress2 { get; set; }

        [StringLength(8000)]
        public string MailingAddress3 { get; set; }

        [StringLength(8000)]
        public string MailingCity { get; set; }

        [StringLength(8000)]
        public string MailingState { get; set; }

        [StringLength(255)]
        public string MailingZip { get; set; }

        [StringLength(20)]
        public string MailingCountry { get; set; }

        [StringLength(255)]
        public string PhoneType1 { get; set; }

        [StringLength(255)]
        public string Phone1 { get; set; }

        [StringLength(255)]
        public string PhoneType2 { get; set; }

        [StringLength(255)]
        public string Phone2 { get; set; }

        [StringLength(255)]
        public string PhoneType3 { get; set; }

        [StringLength(255)]
        public string Phone3 { get; set; }

        [StringLength(255)]
        public string PhoneType4 { get; set; }

        [StringLength(255)]
        public string Phone4 { get; set; }

        [StringLength(255)]
        public string PhoneType5 { get; set; }

        [StringLength(255)]
        public string Phone5 { get; set; }

        [StringLength(255)]
        public string PhoneType6 { get; set; }

        [StringLength(255)]
        public string Phone6 { get; set; }

        [StringLength(8000)]
        public string Email1 { get; set; }

        [StringLength(8000)]
        public string Email2 { get; set; }

        [StringLength(8000)]
        public string Email3 { get; set; }

        [StringLength(255)]
        public string AgencyCode { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(10)]
        public string Language { get; set; }

        [StringLength(255)]
        public string SpectrumAccount { get; set; }

        [StringLength(255)]
        public string SpectrumAccountNo { get; set; }

        [StringLength(255)]
        public string SpectrumAccountStatus { get; set; }

        [StringLength(10)]
        public string PayThruProducer { get; set; }

        [StringLength(255)]
        public string PayThruProducerCode { get; set; }

        public DateTime? ContractDate { get; set; }

        [StringLength(8000)]
        public string BankAccountName { get; set; }

        [StringLength(255)]
        public string BankAccountNo { get; set; }

        [StringLength(8000)]
        public string BankAccountAddress1 { get; set; }

        [StringLength(8000)]
        public string BankAccountAddress2 { get; set; }

        [StringLength(8000)]
        public string BankAccountAddress3 { get; set; }

        [StringLength(8000)]
        public string BankAccountCity { get; set; }

        [StringLength(8000)]
        public string BankAccountState { get; set; }

        [StringLength(255)]
        public string BankAccountZip { get; set; }

        [StringLength(20)]
        public string BankAccountCountry { get; set; }

        [StringLength(8000)]
        public string BankName { get; set; }

        [StringLength(10)]
        public string HoldCommissions { get; set; }

        [StringLength(8000)]
        public string CheckName { get; set; }

        public DateTime? inserted { get; set; }

        [StringLength(50)]
        public string IsLatinAmericaProducer { get; set; }

        public int? IBD { get; set; }

        [StringLength(100)]
        public string ReferredBy { get; set; }

        public double? MinimumCommissionPaymentAmount { get; set; }

        public double? CommissionBalance { get; set; }

        [StringLength(255)]
        public string Wire { get; set; }

        [StringLength(255)]
        public string SpectrumAccountStatements { get; set; }

        [StringLength(255)]
        public string BankSwiftCode { get; set; }

        [StringLength(20)]
        public string ProducerPayTo { get; set; }
    }
}
