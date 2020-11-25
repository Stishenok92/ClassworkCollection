namespace Model.Entity
{
    public class EasyInternet : BasePlan
    {
        private int PackageMb { get; set; }

        public EasyInternet(string name, decimal paymentMonthly, decimal paymentStart, decimal costMinute,
            decimal costMinuteOtherOperator, decimal costMinuteCityPhone, decimal costSms, decimal costSmsOtherOperator,
            decimal costMb, int packageMb) : base(name, paymentMonthly, paymentStart, costMinute,
            costMinuteOtherOperator,
            costMinuteCityPhone, costSms, costSmsOtherOperator, costMb)
        {
            this.PackageMb = packageMb;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nPackage MB: " + PackageMb;
        }
    }
}