namespace Model.Entity
{
    public class EasySay : BasePlan
    {
        private int PackageMinute { get; set; }
        private int PackageSms { get; set; }
        
        public EasySay(string name, decimal paymentMonthly, decimal paymentStart, decimal costMinute,
            decimal costMinuteOtherOperator, decimal costMinuteCityPhone, decimal costSms, decimal costSmsOtherOperator,
            decimal costMb, int packageMinute, int packageSms) : base(name, paymentMonthly, paymentStart, costMinute,
            costMinuteOtherOperator,
            costMinuteCityPhone, costSms, costSmsOtherOperator, costMb)
        {
            this.PackageMinute = packageMinute;
            this.PackageSms = packageSms;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nPackage minute: " + PackageMinute +
                "\nPackage SMS" + PackageSms;
        }
    }
}