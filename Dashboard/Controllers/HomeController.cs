using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Aspose.BarCode.Generation;
using Grpc.Core;

namespace Dashboard.Controllers
{


    [Authorize]
    //[Route("home")]
    public class HomeController : Controller
    {

       

        //[Route("")]
        //[Route("index")]
        //[Route("~/")]
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()    
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login","Access");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public ActionResult Index(Barcode barcode)
        //{
        //    string codeText = barcode.Text;
        //    string imageName = barcode.Text + "." + barcode.ImageType;
        //    string imagePath = "/Images/" + imageName;
        //    string imageServerPath = Server.MapPath("~" + imagePath);

        //    var encodeType = EncodeTypes.Code128;

        //    switch (barcode.BarcodeType)
        //    {
        //        case BarcodeType.Code128:
        //            encodeType = EncodeTypes.Code128;
        //            break;

        //        case BarcodeType.ITF14:
        //            encodeType = EncodeTypes.ITF14;
        //            break;

        //        case BarcodeType.EAN13:
        //            encodeType = EncodeTypes.EAN13;
        //            break;

        //        case BarcodeType.Datamatrix:
        //            encodeType = EncodeTypes.DataMatrix;
        //            break;

        //        case BarcodeType.Code32:
        //            encodeType = EncodeTypes.Code32;
        //            break;

        //        case BarcodeType.Code11:
        //            encodeType = EncodeTypes.Code11;
        //            break;

        //        case BarcodeType.PDF417:
        //            encodeType = EncodeTypes.Pdf417;
        //            break;

        //        case BarcodeType.EAN8:
        //            encodeType = EncodeTypes.EAN8;
        //            break;

        //        case BarcodeType.QR:
        //            encodeType = EncodeTypes.QR;
        //            break;
        //    }

        //    using (Stream str = new FileStream(imageServerPath, FileMode.Create, FileAccess.Write))
        //    {
        //        BarcodeGenerator gen = new BarcodeGenerator(encodeType, codeText);
        //        gen.Save(str, (Aspose.BarCode.Generation.BarCodeImageFormat)barcode.ImageType);
        //    }

        //    ViewBag.ImagePath = imagePath;
        //    ViewBag.ImageName = imageName;

        //    return View();
        //}
        //public ActionResult Download(string ImagePath, string ImageName)
        //{
        //    string contentType = "application/img";
        //    return File(ImagePath, contentType, Path.GetFileName(ImageName));
        //}

    }
}