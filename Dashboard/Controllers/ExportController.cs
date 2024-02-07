using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dashboard.Controllers
{
    public class ExportController : Controller
    {
        //public IActionResult ExportToPDF()
        //{
        //    var htmlContent = ViewRenderHelper.RenderViewToStringAsync(this, "YourReportViewName", data).Result;

        //    var pdf = new ViewAsPdf
        //    {
        //        IsGrayScale = false, // Set to true for grayscale output
        //        PageSize = Size.A4,
        //        FileName = "report.pdf",
        //        PageOrientation = Orientation.Landscape,
        //        CustomSwitches = "--disable-smart-shrinking"
        //    };

        //    pdf.WkHtmlToPdfExecutable = "/path/to/wkhtmltopdf"; // Set the path to wkhtmltopdf executable

        //    pdf.PageMargins.Left = 10;
        //    pdf.PageMargins.Right = 10;
        //    pdf.PageMargins.Top = 20;
        //    pdf.PageMargins.Bottom = 20;

        //    pdf.ViewName = "YourReportViewName"; // The name of your Razor view
        //    pdf.AddItem = data; // Pass your data to the view

        //    return pdf;
        //}
    }
}
