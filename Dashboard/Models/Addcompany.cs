using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class Addcompany
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateofBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public string Occupaation { get; set; }
        public string IDType { get; set; }
        public string IDNumber { get; set; }
        public string IssueAuthority { get; set; }
        public string IssuedState { get; set; }
        public string IssuedDate { get; set; }
        public string ExpiryDate { get; set; }
        public string AddressType { get; set; }
        public string Nationality { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string BlockNumber { get; set; }
        public string Pincode { get; set; }
        public string GST { get; set; }
        public string PanNo { get; set; }
        public string OpeningBalance { get; set; }
        public string BankName { get; set; }
        public string BankAccNo { get; set; }
        public string IFSCCode { get; set; }

    }
}
