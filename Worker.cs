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
    public class Worker               //Class created to organize each worker's information.
    {
        public string name { get; set; }
        public int level { get; set; }
        public double hours { get; set; }
        public double sales { get; set; }

        public Worker(string Name, int Level, double Hours, double Sales)
        {
            level = Level;
            hours = Hours;
            sales = Sales;
            name = Name;
        }
    }
}
