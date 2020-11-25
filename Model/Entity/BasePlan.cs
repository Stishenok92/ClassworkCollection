namespace Model.Entity
{
    public abstract class BasePlan
    {
        protected string Name { get; set; }
        protected decimal PaymentMonthly { get; set; }
        protected decimal PaymentStart { get; set; }
        protected decimal CostMinute { get; set; }
        protected decimal CostMinuteOtherOperator { get; set; }
        protected decimal CostMinuteCityPhone { get; set; }
        protected decimal CostSms { get; set; }
        protected decimal CostSmsOtherOperator { get; set; }
        protected decimal CostMb { get; set; }

        protected BasePlan()
        {
            
        }

        protected BasePlan(string name, decimal paymentMonthly, decimal paymentStart, decimal costMinute,
            decimal costMinuteOtherOperator, decimal costMinuteCityPhone, decimal costSms, decimal costSmsOtherOperator,
            decimal costMb)
        {
            this.Name = name;
            this.PaymentMonthly = paymentMonthly;
            this.PaymentStart = paymentStart;
            this.CostMinute = costMinute;
            this.CostMinuteOtherOperator = costMinuteOtherOperator;
            this.CostMinuteCityPhone = costMinuteCityPhone;
            this.CostSms = costSms;
            this.CostSmsOtherOperator = costSmsOtherOperator;
            this.CostMb = costMb;
        }

        public override string ToString()
        {
            return "Name plan: " + Name +
                   "\nPayment monthly: " + PaymentMonthly +
                   "\nPayment start: " + PaymentStart +
                   "\nCost minute: " + CostMinute +
                   "\nCost minute (other operator): " + CostMinuteOtherOperator +
                   "\nCost minute (city phone): " + CostMinuteCityPhone +
                   "\nCost SMS: " + CostSms +
                   "\nCost SMS (other operator): " + CostSmsOtherOperator +
                   "\nCost MB: " + CostMb;
        }
    }
}