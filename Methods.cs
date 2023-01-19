//Nicholas Coppick
//Last Modified 11/29/2022




using System;
using System.Collections;
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
    public static class Task2Methods
    {
        public static Dictionary<string, PayedWorker> WorkerTotals(List<Worker> workerlist)                        //method to calculate the totals for each worker and add them to a dictionary.
        {
            double commissionrate = 0, hourlyrate = 0, totalsales, totalhourlypay, bonus = 0, totalpay = 0;
            Dictionary<string, PayedWorker> PayedWorkerDict = new Dictionary<string, PayedWorker>();

            foreach (Worker worker in workerlist)
            {
                if (worker.level == 1)
                {
                    if (worker.hours <= 40)
                    {
                        hourlyrate = 12.75;
                    }
                    if (worker.hours > 40)
                    {
                        hourlyrate = 19.125;
                    }
                    if (worker.sales <= 2000)
                    {
                        commissionrate = .0525;
                    }
                    if (worker.sales > 2000 && worker.sales < 3500)
                    {
                        commissionrate = .075;
                    }
                    if (worker.sales >= 3500)
                    {
                        commissionrate = .1075;
                    }
                    totalhourlypay = hourlyrate * worker.hours;
                    totalsales = worker.sales + (worker.sales * commissionrate);
                    if(worker.sales > 24000)
                    {
                        bonus = totalsales * .03;
                    }
                    totalpay = totalsales + totalhourlypay + bonus;
                    PayedWorker CurrentWorker = new PayedWorker(worker.name, totalsales, totalhourlypay, bonus, totalpay);
                    PayedWorkerDict.Add(CurrentWorker.name, CurrentWorker);

                }
                if (worker.level == 2)
                {
                    if (worker.hours <= 40)
                    {
                        hourlyrate = 14.25;
                    }
                    if (worker.hours > 40)
                    {
                        hourlyrate = 21.375;
                    }
                    if (worker.sales <= 2800)
                    {
                        commissionrate = .065;
                    }
                    if (worker.sales > 2800)
                    {
                        commissionrate = .0775;
                    }
                    totalhourlypay = hourlyrate * worker.hours;
                    totalsales = worker.sales * commissionrate;
                    if (worker.sales > 24000)
                    {
                        bonus = totalsales * .03;
                    }
                    totalpay = totalsales + totalhourlypay + bonus;
                    PayedWorker CurrentWorker = new PayedWorker(worker.name, totalsales, totalhourlypay, bonus, totalpay);
                    PayedWorkerDict.Add(CurrentWorker.name, CurrentWorker);

                }
                if (worker.level == 3)
                {
                    if (worker.hours <= 40)
                    {
                        hourlyrate = 17.5;
                    }
                    if (worker.hours > 40)
                    {
                        hourlyrate = 26.25;
                    }
                    commissionrate = .0825;
                    totalhourlypay = hourlyrate * worker.hours;
                    totalsales = worker.sales * commissionrate;
                    if (worker.sales > 24000)
                    {
                        bonus = totalsales * .03;
                    }
                    totalpay = totalsales + totalhourlypay + bonus;
                    PayedWorker CurrentWorker = new PayedWorker(worker.name, totalsales, totalhourlypay, bonus, totalpay);
                    PayedWorkerDict.Add(CurrentWorker.name, CurrentWorker);

                }
                if (worker.level == 4)
                {
                    if (worker.hours <= 40)
                    {
                        hourlyrate = 21.75;
                    }
                    if (worker.hours > 40)
                    {
                        hourlyrate = 32.625;
                    }
                    commissionrate = .0975;
                    totalhourlypay = hourlyrate * worker.hours;
                    totalsales = worker.sales * commissionrate;
                    if (worker.sales > 24000)
                    {
                        bonus = totalsales * .03;
                    }
                    totalpay = totalsales + totalhourlypay + bonus;
                    PayedWorker CurrentWorker = new PayedWorker(worker.name, totalsales, totalhourlypay, bonus, totalpay);
                    PayedWorkerDict.Add(CurrentWorker.name, CurrentWorker);

                }

            }
            return PayedWorkerDict;

        }
    

        public static List<Worker> LoadWorkers()                              //Method to ask the user for the worker's info and add those to a list.
        {
            string workername, answer;
            int workerlevel;
            double workerhours, workersales;
            List<string> yes = new List<string>();
            List<string> no = new List<string>();
            List<Worker> WorkerList = new List<Worker>();
            yes.Add("yes");
            yes.Add("y");
            no.Add("no");
            no.Add("n");

            while(true)
    /*start main loop*/   
            {
                Console.WriteLine("Do you want to enter a new worker?");
                answer = Convert.ToString(Console.ReadLine());
                if(yes.Contains(answer.ToLower()))
                {
                    Console.WriteLine("Enter worker's name.");
                    workername = Convert.ToString(Console.ReadLine());
                    while (true)
 /*level loop*/     {
                        Console.WriteLine("Enter worker's level.");
                        try
                        {
                            workerlevel = Convert.ToInt32(Console.ReadLine());
                            if (workerlevel <= 0 ^ workerlevel > 4)
                            {
                                Console.WriteLine("Worker's level must be between 1-4. Try again.");
                                continue;
                            }
                            if(workerlevel > 0 && workerlevel < 5)
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Worker's level must be an integer between 1-4. Try again.");
                            continue;
                        }
/*level loop end*/  }
/*hours loop  */    while (true)
                    {
                        Console.WriteLine("Enter worker's hours worked.");
                        try
                        {
                            workerhours = Convert.ToDouble(Console.ReadLine());
                            if(workerhours <= 0)
                            {
                                Console.WriteLine("Worker hours must be greater than zero. Try again.");
                                continue;
                            }
                            if(workerhours > 0)
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Worker hours must be a number greather than zero. Try again.");
                            continue;
                        }
/*hours loop end*/  }
                     while(true)
/*sales loop*/       {
                        Console.WriteLine("Enter worker's sales amount.");
                        try
                        {
                            workersales = Convert.ToDouble(Console.ReadLine());
                            if(workersales <= 0)
                            {
                                Console.WriteLine("Worker sales must be greater than zero. Try again.");
                                continue;
                            }
                            if(workersales > 0)
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Worker sales must be a number greater than zero. Try again.");
                            continue;
                        }
 /*end sale loop*/   }
                    Worker CurrentWorker = new Worker(workername, workerlevel, workerhours, workersales);
                    WorkerList.Add(CurrentWorker);
                    continue;
                }
                if(no.Contains(answer.ToLower()))
                {
                    return WorkerList;
                }
                else
                {
                    Console.WriteLine("Invalid entry.(yes/no)");
                    continue;
                }

            }
/*end main loop*/         

        }
        public static double CalculateTotal(Dictionary<string, PayedWorker> worker)
        {
            double total = 0;
            foreach(KeyValuePair<string, PayedWorker> workers in worker)
            {
                total = workers.Value.totalpay + total;
            }
            return total;
        }

    }
}

