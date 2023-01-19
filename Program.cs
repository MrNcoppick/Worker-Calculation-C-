//Nicholas Coppick
//Last Modified 11/29/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2NicholasCoppick
{
    public class Task2NicholasCoppick
    {
        public static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////
            //Main body of code that implements the classes and methods in their respective files.
            //////////////////////////////////////////////////////////////////////////////////////
            
            var list = Task2Methods.LoadWorkers();
            var dict = Task2Methods.WorkerTotals(list);
            var total = Task2Methods.CalculateTotal(dict);
            Console.WriteLine("Total payed to workers is ${0}.", total);
            foreach(KeyValuePair<string, PayedWorker> worker in dict)
            {
                Console.WriteLine(worker.Value.ToString());
            }

        }
    }
}