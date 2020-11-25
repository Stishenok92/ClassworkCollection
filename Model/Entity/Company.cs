using System.Collections.Generic;
using System.Threading;

namespace Model.Entity
{
    public class Company
    {
        public List<BasePlan> plans;
        private List<Client> clients;

        public Company()
        {
            plans = new List<BasePlan>();
            clients = new List<Client>();
        }

        public int CountPlans()
        {
            return plans.Count;
        }

        public int CountClient()
        {
            return clients.Count;
        }
        
        public void AddPlan(BasePlan plan)
        {
            plans.Add(plan);
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public override string ToString()
        {
            string result = "\n";
            
            foreach (BasePlan plan in plans)
            {
                result += plan.ToString() + "\n\n";
            }
            ;
            return result;
        }
    }
}