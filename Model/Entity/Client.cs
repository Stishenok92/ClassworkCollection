using System.Collections;

namespace Model.Entity
{
    public class Client
    {
        private string Surname;
        private string Name;
        private string Number;
        private ArrayList plans;

        public Client(string surname, string name, string number, params BasePlan[] plans)
        {
            this.Surname = surname;
            this.Name = name;
            this.Number = number;

            foreach (BasePlan plan in plans)
            {
                this.plans.Add(plan);
            }
        }

        private string ShowPlans()
        {
            string result = "";

            foreach (BasePlan plan in plans)
            {
                result += plan.ToString() + " ";
            }

            return result;
        }

        public override string ToString()
        {
            return
                "Surname:" + Surname +
                "Name: " + Name +
                "Number: " + Number + 
                "Plans: " + ShowPlans();
        }
    }
}