using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace Dashboard.Controllers
{
    public class SupplierController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public SupplierController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }
        //      public IActionResult Create()
        //      {
        //          ViewBag.SupplierSelectList = new SelectList(GetSuppliers(), "Id", "District");
        //          ViewBag.GenderSelectList = new SelectList(Getgender(), "Id", "Gender");
        //          ViewBag.NationalitySelectList = new SelectList(Getnationality(), "Id", "Nationality");
        //          return View();
        //      }
        //      private List<Supplier>GetSuppliers()
        //      {
        //          var suppliers = new List<Supplier>();
        //          suppliers.Add(new Supplier { Id = 1, District = "plakkad" });
        //	suppliers.Add(new Supplier { Id = 2, District = "kozhikod" });
        //	suppliers.Add(new Supplier { Id = 3, District = "Ernakulam" });

        //          return suppliers;
        //}
        //      private List<Supplier> Getgender()
        //      {
        //          var gender = new List<Supplier>();
        //          gender.Add(new Supplier { Id = 1, Gender = "Male" });
        //          gender.Add(new Supplier { Id = 2, Gender = "Female" });
        //          gender.Add(new Supplier { Id = 3, Gender = "Other" });
        //          return gender;
        //      }

        //      private List<Supplier> Getnationality()
        //      {
        //          var nationality = new List<Supplier>();
        //          nationality.Add(new Supplier { Id = 1, Nationality = "India" });
        //          nationality.Add(new Supplier { Id = 3, Nationality = "USA" });
        //          return nationality;     
        //      }
        //      [HttpGet]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var suppliers = await mvcDbContext.Suppliers.ToListAsync();
            return View(suppliers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Supplier supplierRequest)
        {
            var addsupplier = new Addsupplier
            {
                Id = supplierRequest.Id,
                Name = supplierRequest.Name,
                DateofBirth = supplierRequest.DateofBirth,
                Email = supplierRequest.Email,
                PhoneNo = supplierRequest.PhoneNo,
                Gender = supplierRequest.Gender,
                Occupaation = supplierRequest.Occupaation,
                IDType = supplierRequest.IDType,
                IDNumber = supplierRequest.IDNumber,
                IssueAuthority = supplierRequest.IssueAuthority,
                IssuedState = supplierRequest.IssuedState,
                IssuedDate = supplierRequest.IssuedDate,
                ExpiryDate = supplierRequest.ExpiryDate,
                AddressType = supplierRequest.AddressType,
                Nationality = supplierRequest.Nationality,
                District = supplierRequest.District,
                State = supplierRequest.State,
                BlockNumber = supplierRequest.BlockNumber,
                Pincode = supplierRequest.Pincode,
                GST = supplierRequest.GST,
                PanNo = supplierRequest.PanNo,
                OpeningBalance = supplierRequest.OpeningBalance,
                BankName = supplierRequest.BankName,
                BankAccNo = supplierRequest.BankAccNo,
                IFSCCode = supplierRequest.IFSCCode

            };
            await mvcDbContext.Suppliers.AddAsync(addsupplier);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }

        public async Task<IActionResult> View(int id)
        {
            var addsupplier = await mvcDbContext.Suppliers.FirstOrDefaultAsync(x => x.Id == id);

            if (addsupplier != null)
            {
                var viewModel = new Supplier()
                {
                    Id = addsupplier.Id,
                    Name = addsupplier.Name,
                    DateofBirth = addsupplier.DateofBirth,
                    Email = addsupplier.Email,
                    PhoneNo = addsupplier.PhoneNo,
                    Gender = addsupplier.Gender,
                    Occupaation = addsupplier.Occupaation,
                    IDType = addsupplier.IDType,
                    IDNumber = addsupplier.IDNumber,
                    IssueAuthority = addsupplier.IssueAuthority,
                    IssuedState = addsupplier.IssuedState,
                    IssuedDate = addsupplier.IssuedDate,
                    ExpiryDate = addsupplier.ExpiryDate,
                    AddressType = addsupplier.AddressType,
                    Nationality = addsupplier.Nationality,
                    District = addsupplier.District,
                    State = addsupplier.State,
                    BlockNumber = addsupplier.BlockNumber,
                    Pincode = addsupplier.Pincode,
                    GST = addsupplier.GST,
                    PanNo = addsupplier.PanNo,
                    OpeningBalance = addsupplier.OpeningBalance,
                    BankName = addsupplier.BankName,
                    BankAccNo = addsupplier.BankAccNo,
                    IFSCCode = addsupplier.IFSCCode,



                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(Supplier model)
        {
            var addsupplier = await mvcDbContext.Suppliers.FindAsync(model.Id);
            if (addsupplier != null)
            {
                addsupplier.Name = model.Name;
                addsupplier.DateofBirth = model.DateofBirth;
                addsupplier.Email = model.Email;
                addsupplier.PhoneNo = model.PhoneNo;
                addsupplier.Gender = model.Gender;
                addsupplier.Occupaation = model.Occupaation;
                addsupplier.IDType = model.IDType;
                addsupplier.IDNumber = model.IDNumber;
                addsupplier.IssueAuthority = model.IssueAuthority;
                addsupplier.IssuedState = model.IssuedState;
                addsupplier.IssuedDate = model.IssuedDate;
                addsupplier.ExpiryDate = model.ExpiryDate;
                addsupplier.AddressType = model.AddressType;
                addsupplier.Nationality = model.Nationality;
                addsupplier.District = model.District;
                addsupplier.State = model.State;
                addsupplier.BlockNumber = model.BlockNumber;
                addsupplier.Pincode = model.Pincode;
                addsupplier.GST = model.GST;
                addsupplier.PanNo = model.PanNo;
                addsupplier.OpeningBalance = model.OpeningBalance;
                addsupplier.BankName = model.BankName;
                addsupplier.BankAccNo = model.BankAccNo;
                addsupplier.IFSCCode = model.IFSCCode;



                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Supplier model)
        {
            var addsupplier = await mvcDbContext.Suppliers.FindAsync(model.Id);

            if (addsupplier != null)
            {
                mvcDbContext.Suppliers.Remove(addsupplier);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
