//Nicholas Coppick
//Last Modified 11/29/2022



using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Task2NicholasCoppick
{

    public class PayedWorker                             //Class created to store info for each worker after the calculations were complete
    {
        public string name { get; set; }
        public double totalcommission { get; set; }
        public double totalhourly { get; set; }
        public double bonus { get; set; }
        public double totalpay { get; set; }    
        public PayedWorker(string Name, double TotalCommission, double TotalHourly, double Bonus, double TotalPay)
        {
            name = Name;
            totalcommission = TotalCommission;
            totalhourly = TotalHourly;
            bonus = Bonus;
            totalpay = TotalPay;
        }

        public override string ToString()                                           //I figured I would only need a ToString method post-calculations, hense why this is the only one with one.
        {
            return string.Format("{0}'s hourly pay is ${1}, commission pay is ${2}, and bonus is ${3}. Total ${4}",
                name, totalhourly, totalcommission, bonus, totalpay);
        }

    }
}