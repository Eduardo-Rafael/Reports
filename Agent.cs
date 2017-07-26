using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    class Agent
    {
        //Fields
        private string ven_pmt_type;
        private string dd_routing_no;
        private string dd_intermediary_bank_name;
        private string dd_intermediary_act_no;
        private string dd_intermediary_routing_no;
        private string dd_ffc_account;
        private string dd_ffc_name;
        //Properties
        public string PHONETYPE1 { get; set; }
        public string PHONE1 { get; set; }
        public string PHONETYPE2 { get; set; }
        public string PHONE2 { get; set; }
        public string PHONETYPE3 { get; set; }
        public string PHONE3 { get; set; }
        public string PHONETYPE4 { get; set; }
        public string PHONE4 { get; set; }
        public string PHONETYPE5 { get; set; }
        public string PHONE5 { get; set; }
        public string PHONETYPE6 { get; set; }
        public string PHONE6 { get; set; }
        public string PRODUCER_CODE { get; set; }
        public string PRODUCER_PAY_TO { get; set; }
        public bool? PATRIARCH { get; set; }
        public string VEN_CD { get; set; }
        public string VEN_NAME { get; set; }
        public string VEN_ADDR1 { get; set; }
        public string VEN_ADDR2 { get; set; }
        public string VEN_CITY { get; set; }
        public string VEN_STATE { get; set; }
        public string VEN_ZIP { get; set; }
        public string VEN_COUNTRY { get; set; }
        //TENGO QUE VER EL CASO DEL TELEPHONO
        public string VEN_PHONE1
        {
            get
            {
                if (!PHONETYPE1.Contains("Fax")) return PHONE1.Substring(0);
                else if (!PHONETYPE2.Contains("Fax")) return PHONE2.Substring(0);
                else if (!PHONETYPE3.Contains("Fax")) return PHONE3.Substring(0);
                else if (!PHONETYPE4.Contains("Fax")) return PHONETYPE4.Substring(0);
                else if (!PHONETYPE5.Contains("Fax")) return PHONETYPE5.Substring(0);
                else return PHONETYPE6.Substring(0);

            }
        }
        public string VEN_EMAIL_1 { get; set; }
        public string VEN_PMT_TYPE
        {
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToUpper() == "CHECK" || value.ToUpper() == "NO" || value.ToUpper() == "N") ven_pmt_type = "CK";
                else if (value.ToUpper() == "WIRE" || value.ToUpper() == "ACH" || value.ToUpper() == "YES" || value.ToUpper() == "Y") ven_pmt_type = "ON";
            }
            get { return ven_pmt_type; }
        }
        public string DD_ROUTING_NO
        {
            set
            {
                if (string.IsNullOrEmpty(value)) dd_routing_no = "";
                else dd_routing_no = value;
            }
            get { return dd_routing_no; }
        } 
        public string DD_DFI_ACCT { get; set; }
        public string VEN_CATEGORY { get; set; }
        public string VEN_CURR_CD { get; set; }
        public string VEN_GRP_CD { get; set; }
        public string DD_INTERMEDIARY_BANK_NAME
        {
            set
            {
                if (string.IsNullOrEmpty(value)) dd_intermediary_bank_name = "";
                else dd_intermediary_bank_name = value;
            }
            get { return dd_intermediary_bank_name; }
        }
        public string DD_INTERMEDIARY_ROUTING_NO
        {
            set
            {
                if (string.IsNullOrEmpty(value)) dd_intermediary_routing_no = "";
                else dd_intermediary_routing_no = value;
            }
            get { return dd_intermediary_routing_no; }
        }
        public string DD_INTERMEDIARY_ACT_NO
        {
            set
            {
                if (string.IsNullOrEmpty(value)) dd_intermediary_act_no = "";
                else dd_intermediary_act_no = value;
            }
            get { return dd_intermediary_act_no; }
        }
        public string DD_FFC_ACCOUNT
        {
            set
            {
                if (string.IsNullOrEmpty(value)) dd_ffc_account = "";
                else dd_ffc_account = value;
            }
            get { return dd_ffc_account; }
        }
        public string DD_FFC_NAME
        {
            set
            {
                if (string.IsNullOrEmpty(value)) dd_ffc_name = "";
                else dd_ffc_name = value;
            }
            get { return dd_ffc_name; }
        }
        public string VOU_INV_NO { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? TransactionProccesDate { get; set; }
        public string VOU_COMMENT { get; set; }
        public string VOU_INV_DT { get; set; }
        public string VOU_RECEIVED_DT { get; set; }
        public string VOU_REFERENCE { get; set; }
        public decimal? VOU_TO_BE_PAID { get; set; }
        //public string VOU_RATE { get; set; }
        public string VOU_CO { get; set; }
        public string VOU_DB_SEG1 { get; set; }
        public string VOU_DB_SEG2 { get; set; }
        public string VOU_DB_SEG3 { get; set; }
        public string VOU_DB_SEG4 { get; set; }

    }
}
