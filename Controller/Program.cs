using static Model.BusinessLogic;
using static View.Printer;
using static Util.UserInput;
using System;
using Model.Entity;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            
            company.AddPlan(new Easy("Легкий", 20, 10, 0.2m,
                0.3m, 0.3m, 0.15m, 0.2m,
                0.2m));
            company.AddPlan(new EasyInternet("Легкий интернет", 20, 10, 0.2m,
            0.3m, 0.3m, 0.15m, 0.2m,
            0.2m, 2000));
            company.AddPlan(new EasySay("Легко говорить", 20, 10, 0.2m,
                0.3m, 0.3m, 0.15m, 0.2m,
                0.2m, 100, 100));
            company.AddPlan(new EasySmart("Легкий смартфон", 20, 10, 0.2m,
                0.3m, 0.3m, 0.15m, 0.2m,
                0.2m, 100, 100, 5000));

            Console.WriteLine("Plans:");
            Console.Write(company);
            Console.WriteLine("Count plans: " + company.CountPlans());

            company.AddClient(new Client("Stishenok", "Vadim", "+375256686756", company.plans[1]));
        }
    }
}