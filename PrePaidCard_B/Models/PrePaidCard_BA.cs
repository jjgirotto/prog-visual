namespace PrePaidCard_B.Models
{
    public class PrePaidCard_BA
    {
        public Guid Id_B { get; set; }
        public string HolderName_B { get; set; }
        public DateTime ExpiryDate_B { get; set; }
        public decimal Credit_B { get; set; }

        public PrePaidCard_BA(string holderName, decimal startingCredit)
        {
            HolderName_B = holderName;
            Credit_B = startingCredit;
            ExpiryDate_B = DateTime.UtcNow.AddYears(5);
            Id_B = Guid.NewGuid();
        }

        public PrePaidCard_BA() : this ("Sem nome", 0m)
        {
            
        }

    }
}
