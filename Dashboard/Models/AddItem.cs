using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dashboard.Models.Domain;

namespace Dashboard.Models
{
    public class AddItem
    {
        [Key]
        public int Id { get; set; }
        public string ItemNameId { get; set; }
        public string ItemCodeId { get; set; }
        public string CategoryId { get; set; }
        public string ManufacturerId { get; set; }
        public string BrandId { get; set; }
        public string GSTId { get; set; }
        public string UnitId { get; set; }
        //public string MultipleUnit { get; set; }
        public string HSNCode { get; set; }
        public string BatchId { get; set; }
        //public int BarcodeId{ get; set; }
        public string MRPId { get; set; }
        public string PurchasePriceId { get; set; }
        public string LandingCostId { get; set; }
        public string SalePriceId { get; set; }
        public string SalesDiscount { get; set; }
        public string OpeningQuantity { get; set; }
        public string RackColor { get; set; }
        public string ColorCode { get; set; }
        public string QuantityWarning { get; set; }
        public string IMEnumber { get; set; }
       
        public string ItemPackedDate { get; set; }
        
        public string ItemExpiryDate { get; set; }
        
        public string ItemManuDate { get; set; }
       
        public string ItemIssuedDate { get; set; }
        public string Discription { get; set; }

        public List<Category> Categories { get; set; }


    }
}
