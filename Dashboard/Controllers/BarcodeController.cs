using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
//using Dashboard.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Data;
using Dashboard.Models;
using IronBarCode;

namespace Dashboard.Controllers
{
    public class BarcodeController : Controller
    {
        private readonly MVCDbContext mvcDbContext;


        //public BarcodeController(MVCDbContext mvcDbContext)
        //{
        //    this.mvcDbContext = mvcDbContext;
        //}
        private IWebHostEnvironment _webHostEnvironment;

        public BarcodeController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BarcodeModel model)
        {
            try
            {
                GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(model.BarcodeText,
                    BarcodeWriterEncoding.Code128);
                barcode.ResizeTo(500, 150);
                barcode.AddBarcodeValueTextBelowBarcode();
                barcode.ChangeBarCodeColor(Color.DarkBlue);
                barcode.SetMargins(10);
                string path = Path.Combine(_webHostEnvironment.WebRootPath,
                    "BarCodeFile");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filePath = Path.Combine(
                    _webHostEnvironment.WebRootPath, "BarCodeFile/barcode.png");
                barcode.SaveAsPng(filePath);
                string filename = Path.GetFileName(filePath);
                string imageUrl = $"{this.Request.Scheme}://" +
                    $"{this.Request.Host}{this.Request.PathBase}" + "/BarCodeFile/" + filename;
                ViewBag.barcode1 = imageUrl;
            }
            catch (Exception)
            {
                throw;

            }
            return View();
        }

        //[HttpGet]
        //public IActionResult Add()
        //{
        //    var items = mvcDbContext.Items
        //       .Select(item => item.ItemNameId).Distinct().ToList();
        //    ViewBag.items = items;

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult GetItemDetails(string itemNamePrefix)
        //{
        //    var items = mvcDbContext.Items
        //            .Where(item => item.ItemNameId.StartsWith(itemNamePrefix))
        //           .ToList();

        //    return Json(items);
        //}
    }

}



            //[HttpPost]
            //      public IActionResult GenerateBarcode(BarcodeInputModel model)
            //      {

            //          //if(!Enum.TryParse(format, out BarcodeFormat barcodeFormat))
            //          //{

            //          //}

            //          //var barcodeFormat = BarcodeFormat.QR_CODE;

            //          var writer = new BarcodeWriter<Bitmap>
            //          {
            //              Format = BarcodeFormat.QR_CODE,
            //              Options = new QrCodeEncodingOptions
            //              {
            //                  Width = 300,
            //                  Height = 300,
            //              }
            //          };

            //          Bitmap barcodeBitmap = writer.Write(model.Text);

            //          using (MemoryStream ms = new MemoryStream())
            //          {

            //              barcodeBitmap.Save(ms, ImageFormat.Png);
            //              byte[] barcodeBytes = ms.ToArray();

            //              ViewBag.BarcodeImage = "data:image/png;base64," + Convert.ToBase64String(barcodeBytes); /*Convert.ToBase64String(barcodeBytes)*/

            //          }

            //          return View();
            //      }
            //[HttpPost]
            //public IActionResult GenerateCodes(string number)
            //{
            //    if (string.IsNullOrEmpty(number))
            //    {
            //        //Handle empty input
            //        return View();
            //    }
            //    BarcodeWriter barcodeWriter = new BarcodeWriter();
            //    barcodeWriter.Format = BarcodeFormat.QR_CODE;
            //    EncodingOptions encodingOptions = new QrCodeEncodingOptions
            //    {
            //        Width = 200,
            //        Height = 200
            //    };
            //    barcodeWriter.Options = encodingOptions;

            //    var qrCodeBitmap = barcodeWriter.Write(number);

            //    var qrCodeBase64 = ConvertBitmapToBase64(qrCodeBitmap);
            //    ViewBag.QRCodeImageBase64 = qrCodeBase64;
            //    return View();
            //}

            /// /generate QR Code using Zxing.Net
            //BarcodeWriterPixelData barcodeWriter = new BarcodeWriterPixelData();
            //barcodeWriter.Format = BarcodeFormat.QR_CODE;
            //var qrCodeBitmap = barcodeWriter.Write(number);
            //var qrCodeBase64 = ConvertImageToBase64(qrCodeBitmap);

            //ViewBag.QRCodeImage = qrCodeBase64;

            ////generate QR Code using Zxing.Net
            //var qrCodeWriter = new BarcodeWriterPixelData
            //         {
            //             Format = BarcodeFormat.QR_CODE,
            //             Options = new QrCodeEncodingOptions
            //             {
            //                 Width = 200,
            //                 Height = 200
            //             }
            //         };
            //var qrCodeBitmap = qrCodeWriter.Write(number);
            //var qrCodeBase64 = ConvertBitmapToBase64(qrCodeBitmap);
            //qrCodeWriter.Format = BarcodeFormat.QR_CODE;
            //         qrCodeWriter.Options = new ZXing.Common.EncodingOptions
            //         {
            //             Width = 200,
            //             Height = 200
            //         };
            //         var qrCodeBitmap = qrCodeWriter.Write(number);
            //         var qrCodeBase64 = ConvertBitmapToBase64(qrCodeBitmap);

            //Generate Barcode using BarcodeLibrary
            //Barcode barcode = new Barcode();
            //Image barcodeImage = barcode.Encode(TYPE.CODE128, number, Color.Black, Color.White, 300, 150);
            //var barcodeBase64 = ConvertImageToBase64(barcodeImage);


            //    //ViewBag.QRCodeImage = qrCodeBase64;
            //    ViewBag.BarcodeImage = barcodeBase64;

            //    return View();
            //}



            //private object ConvertBitmapToBase64(SKImage barcodeImage)
            //{
            //	throw new NotImplementedException();
            //}

            //private object ConvertBitmapToBase64(PixelData qrCodeBitmap)
            //{
            //	throw new NotImplementedException();
            //}
            //private string ConvertBitmapToBase64(Bitmap bitmap)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        //image.Save(memorystream, System.Drawing.Imaging.ImageFormat.Png);
            //        bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //        return "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
            //    }
            //}

            //private string ConvertImageToBase64(Image image)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //        //bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            //        return "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
            //    }
            //}
        

