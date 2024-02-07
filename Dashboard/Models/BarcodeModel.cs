using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Dashboard.Models
{
    public class BarcodeModel
    {
       [Display(Name ="Enter bar code Text")]
       public string BarcodeText { get; set; } 


    }
}
