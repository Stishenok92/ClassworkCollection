namespace Model.Entity
{
    public class EasySmart : BasePlan
    {
        private int PackageMinute { get; set; }
        private int PackageSms { get; set; }
        private int PackageMb { get; set; }
        
        public EasySmart(string name, decimal paymentMonthly, decimal paymentStart, decimal costMinute,
            decimal costMinuteOtherOperator, decimal costMinuteCityPhone, decimal costSms, decimal costSmsOtherOperator,
            decimal costMb, int packageMinute, int packageSms, int packageMb) : base(name, paymentMonthly, paymentStart, costMinute,
            costMinuteOtherOperator,
            costMinuteCityPhone, costSms, costSmsOtherOperator, costMb)
        {
            this.PackageMinute = packageMinute;
            this.PackageSms = packageSms;
            this.PackageMb = packageMb;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nPackage minute: " + PackageMinute +
                   "\nPackage SMS" + PackageSms +
                   "\nPackage MB: " + PackageMb;
        }
    }
}