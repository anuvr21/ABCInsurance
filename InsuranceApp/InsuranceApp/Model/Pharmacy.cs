using System.ComponentModel.DataAnnotations;



namespace InsuranceApp.Model
{
    public class Pharmacy
    {
        [Key]
        public string? MEMBERNUMBER { get; set; }
        public string? PROVIDERID { get; set; }



        public int? RXFILLDATE { get; set; }



        public int? RXDAYSSUPPLY { get; set; }



        public int? QUANTITY { get; set; }



        public string? UNITSOFMEASURE { get; set; }
    }
}