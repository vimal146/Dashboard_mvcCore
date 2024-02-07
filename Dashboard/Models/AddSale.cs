using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class AddSale
    {
        [Key]
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string PoNo { get; set; }
        public string InvoiceNo { get; set; }
        public string Date { get; set; }
        public string B2BInvoice { get; set; }
        public string B2CInvoice { get; set; }
        public string AccountType { get; set; }
        public string Address { get; set; }
        public string Particular { get; set; }
        public string Itemcode { get; set; }
        public string Barcode { get; set; }
        public string BatchNo { get; set; }
        public string MRP { get; set; }
        public string Qty { get; set; }
        public string PurchasePrize { get; set; }
        public string SalePrize { get; set; }
        public string Discount { get; set; }
        public string Gst { get; set; }
        public string Cgst { get; set; }
        public string Sgst { get; set; }
        public string Amount { get; set; }
    }
}
