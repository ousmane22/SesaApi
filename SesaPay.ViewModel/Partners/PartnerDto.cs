namespace SesaPay.ViewModels.Partner
{
   
    public class PartnerModel
    {
        public int Id { get; set; }

        public string PartnerName { get; set; }

        public string? PartnerOperator  { get; set; }

        public string? PartnerEmail { get; set; }

        public int PhoneCode { get; set; }

        public int MobileNumber { get; set; }

        public string? Password { get; set; }
    }
}
