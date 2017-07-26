using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    class Controller
    {
        //Fields
        private Apt_live context;
        private Files file;
        Dictionary<string, decimal?> Petriarchs;
        //Methods
        public Controller()
        {
            context = new Apt_live();
            file = new Files() {SBT_VENDORS = new List<string>() , SBT_VOUCHER = new List<string>()};
            file.SBT_VENDORS.Add("VEN_CD\tVEN_NAME\tVEN_ADDR1\tVEN_ADDR2\tVEN_CITY\tVEN_STATE\tVEN_ZIP\tVEN_COUNTRY\tVEN_PHONE1\t"+
                                 "VEN_EMAIL_1\tVEN_PMT_TYPE\tDD_ROUTING_NO\tDD_DFI_ACCT\tVEN_CATEGORY\tVEN_CURR_CD\tVEN_GRP_CD\t"+
                                 "DD_INTERMEDIARY_BANK_NAME\tDD_INTERMEDIARY_ACT_NO\tDD_INTERMEDIARY_ROUTING_NO\tDD_FFC_ACCOUNT\t"+
                                 "DD_FFC_NAME\r");
            file.SBT_VOUCHER.Add("VOU_VEN_GRP\tVOU_VEN_CD\tVOU_INV_NO\tVOU_COMMENT\tVOU_INV_DATE\tVOU_RECEIVED_DT\tVOU_REFERENCE\t"+
                                 "VOU_TO_BE_PAID\tVOUD_RATE\tVOU_CO\tVOUD_DB_SEG1\tVOUD_DB_SEG2\tVOUD_DB_SEG3\tVOUD_DB_SEG4\r");
            Petriarchs = new Dictionary<string, decimal?>();
        }
        public Files Get_Reports(string Time_Period)
        {
            //Get all Producers to be paid
            var general_query_1 = (from producer in context.Producers
                                 join tran in context.Transactions
                                 on producer.ProducerCode equals tran.Code
                                 join pm in context.ProducersPaymentMethods
                                 on producer.Wire equals pm.Method
                                 where tran.PaymentReferenceDisplay == "COMMISSION PAYMENT " + Time_Period
                                 select new Agent()
                                 {
                                     PRODUCER_CODE = producer.ProducerCode,
                                     TransactionDate = tran.TransactionDate,
                                     TransactionProccesDate = tran.ProcessDate,
                                     PATRIARCH = pm.Patriarch,
                                     PRODUCER_PAY_TO = producer.ProducerPayTo,
                                     VEN_CD = "LI" + producer.id,
                                     VEN_NAME = producer.DisplayName,
                                     VEN_ADDR1 = producer.MailingAddress1,
                                     VEN_ADDR2 = producer.MailingAddress2,
                                     VEN_CITY = producer.MailingCity,
                                     VEN_STATE = producer.MailingState,
                                     VEN_ZIP = producer.MailingZip,
                                     VEN_COUNTRY = producer.MailingCountry,
                                     PHONETYPE1 = producer.PhoneType1,
                                     PHONE1 = producer.Phone1,
                                     PHONE2 = producer.Phone2,
                                     PHONE3 = producer.Phone3,
                                     PHONE4 = producer.Phone4,
                                     PHONE5 = producer.Phone5,
                                     PHONE6 = producer.Phone6,
                                     PHONETYPE2 = producer.PhoneType2,
                                     PHONETYPE3 = producer.PhoneType3,
                                     PHONETYPE4 = producer.PhoneType4,
                                     PHONETYPE5 = producer.PhoneType5,
                                     PHONETYPE6 = producer.PhoneType6,
                                     VEN_EMAIL_1 = producer.Email1,
                                     VEN_PMT_TYPE = producer.Wire,
                                     DD_ROUTING_NO = producer.BankSwiftCode,
                                     DD_DFI_ACCT = producer.BankAccountNo,
                                     VEN_CATEGORY = "LI",
                                     VEN_CURR_CD = "USD",
                                     VEN_GRP_CD = "COMM",
                                     DD_INTERMEDIARY_BANK_NAME = producer.SpectrumAccountStatus,
                                     DD_INTERMEDIARY_ACT_NO = producer.SpectrumAccountNo,
                                     DD_INTERMEDIARY_ROUTING_NO = producer.SpectrumAccount,
                                     DD_FFC_ACCOUNT = producer.BankAccountAddress3,
                                     DD_FFC_NAME = producer.SpectrumAccountStatements,                                     
                                     VOU_COMMENT = tran.PaymentReferenceDisplay.Substring("COMMISSION PAYMENT ".Length + 1, tran.PaymentReferenceDisplay.Length - "COMMISSION PAYMENT ".Length + 1),        
                                     VOU_RECEIVED_DT = tran.ProcessDate.ToString(),
                                     VOU_REFERENCE = "COMMISSIONS ",
                                     VOU_TO_BE_PAID = Math.Abs((decimal)tran.Amount),
                                     VOU_CO = "732",
                                     VOU_DB_SEG1 = "732",
                                     VOU_DB_SEG2 = "20052",
                                     VOU_DB_SEG3 = "2000",
                                     VOU_DB_SEG4 = "0"
                                 }).ToArray();

            //get all producers who have a patriach
            var query_2 = from producer in general_query_1
                          where producer.PATRIARCH == true  && producer.PRODUCER_CODE != producer.PRODUCER_PAY_TO
                          select producer;

            foreach (var item in query_2)
            {
                if (!Petriarchs.ContainsKey(item.PRODUCER_PAY_TO))
                    Petriarchs.Add(item.PRODUCER_PAY_TO, item.VOU_TO_BE_PAID);
                else
                    Petriarchs[item.PRODUCER_PAY_TO] += item.VOU_TO_BE_PAID;
            }

            var query_3 = from producer in general_query_1
                          where producer.PATRIARCH == false || producer.PRODUCER_CODE == producer.PRODUCER_PAY_TO
                          select producer;

            foreach (var item in query_3)
            {
                item.VOU_INV_NO = item.PRODUCER_CODE + "_" + ((DateTime)item.TransactionDate).Date.GetDateTimeFormats('d')[0];
                item.VOU_INV_DT = item.TransactionDate.Value.Date.GetDateTimeFormats('d')[0];
                item.VOU_RECEIVED_DT = item.TransactionProccesDate.Value.Date.GetDateTimeFormats('d')[0];
                item.VOU_REFERENCE += item.TransactionDate.Value.Date.GetDateTimeFormats('d')[0];


                if (Petriarchs.ContainsKey(item.PRODUCER_CODE))
                    item.VOU_TO_BE_PAID += Petriarchs[item.PRODUCER_CODE];

                file.SBT_VENDORS.Add(item.VEN_CD + "\t" + item.VEN_NAME + "\t" + item.VEN_ADDR1 + "\t" + item.VEN_ADDR2 + "\t" +
                                     item.VEN_CITY + "\t" + item.VEN_STATE + "\t" + item.VEN_ZIP + "\t" + item.VEN_COUNTRY + "\t" +
                                     item.VEN_PHONE1 + "\t" + item.VEN_EMAIL_1 + "\t" + item.VEN_PMT_TYPE + "\t" + item.DD_ROUTING_NO + "\t" +
                                     item.DD_DFI_ACCT + "\t" + item.VEN_CATEGORY + "\t" + item.VEN_CURR_CD + "\t" + item.VEN_GRP_CD + "\t" +
                                     item.DD_INTERMEDIARY_BANK_NAME + "\t" + item.DD_INTERMEDIARY_ACT_NO + "\t" + item.DD_INTERMEDIARY_ROUTING_NO + "\t" + 
                                     item.DD_FFC_ACCOUNT + "\t" + item.DD_FFC_NAME + "\r");

                file.SBT_VOUCHER.Add(item.VEN_GRP_CD + "\t" + item.VEN_CD + "\t" + item.VOU_INV_NO + "\t" + item.VOU_COMMENT + "\t" + item.VOU_INV_DT + "\t" +
                                     item.VOU_RECEIVED_DT + "\t" + item.VOU_REFERENCE + "\t" + item.VOU_TO_BE_PAID + "\t" + item.VOU_TO_BE_PAID + "\t" +
                                     item.VOU_CO + "\t" + item.VOU_DB_SEG1 + "\t" + item.VOU_DB_SEG2 + "\t" + item.VOU_DB_SEG3 + "\t" + item.VOU_DB_SEG4 + "\r");
            }


            return file;
        }
    }
}
