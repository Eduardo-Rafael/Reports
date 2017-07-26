using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controladora = new Controller();
            Files reports = controladora.Get_Reports("7/13/2017 - 7/19/2017");
            //File.Create(@"D:\eduardo\Applicaciones\Reports\Reports\Reports\Vendors.txt");
            //File.Create(@"D:\eduardo\Applicaciones\Reports\Reports\Reports.txt");
            foreach (var item in reports.SBT_VENDORS)
            {
                File.AppendAllText(@"D:\eduardo\Applicaciones\Reports\Reports\Reports\Vendors.txt", item);
            }

            foreach (var  item in reports.SBT_VOUCHER)
            {
                File.AppendAllText(@"D:\eduardo\Applicaciones\Reports\Reports\Reports\Voucher.txt", item);
            }
            Console.WriteLine("Succesfull");
            Console.ReadLine();
        }
    }
}
