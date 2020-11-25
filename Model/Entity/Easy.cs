namespace Model.Entity
{
    public class Easy : BasePlan
    {
        public Easy()
        {
            
        }

        public Easy(string name, decimal paymentMonthly, decimal paymentStart, decimal costMinute,
            decimal costMinuteOtherOperator, decimal costMinuteCityPhone, decimal costSms, decimal costSmsOtherOperator,
            decimal costMb) : base(name, paymentMonthly, paymentStart, costMinute, costMinuteOtherOperator,
            costMinuteCityPhone, costSms, costSmsOtherOperator, costMb)
        {
            
        }
    }
}