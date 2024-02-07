using Microsoft.AspNetCore.Mvc;
using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace Dashboard.Controllers
{
    public class CustomerController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public CustomerController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customers = await mvcDbContext.Customers.ToListAsync();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Addcustomer addcustomerRequest)
        {
            var customer = new Customer
            {
                Id = addcustomerRequest.Id,
                Name = addcustomerRequest.Name,
                DateofBirth = addcustomerRequest.DateofBirth,
                Email = addcustomerRequest.Email,
                PhoneNo = addcustomerRequest.PhoneNo,
                Gender = addcustomerRequest.Gender,
                Occupaation = addcustomerRequest.Occupaation,
                IDType = addcustomerRequest.IDType,
                IDNumber = addcustomerRequest.IDNumber,
                IssueAuthority = addcustomerRequest.IssueAuthority,
                IssuedState = addcustomerRequest.IssuedState,
                IssuedDate = addcustomerRequest.IssuedDate,
                ExpiryDate = addcustomerRequest.ExpiryDate,
                AddressType = addcustomerRequest.AddressType,
                Nationality = addcustomerRequest.Nationality,
                District = addcustomerRequest.District,
                State = addcustomerRequest.State,
                BlockNumber = addcustomerRequest.BlockNumber,
                Pincode = addcustomerRequest.Pincode,
                GST = addcustomerRequest.GST,
                PanNo = addcustomerRequest.PanNo,
                OpeningBalance = addcustomerRequest.OpeningBalance,
                BankName = addcustomerRequest.BankName,
                BankAccNo = addcustomerRequest.BankAccNo,
                IFSCCode = addcustomerRequest.IFSCCode

            };
            await mvcDbContext.Customers.AddAsync(customer);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }

        public async Task<IActionResult> View(int id)
        {
            var customer = await mvcDbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customer != null)
            {
                var viewModel = new Addcustomer()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    DateofBirth = customer.DateofBirth,
                    Email = customer.Email,
                    PhoneNo = customer.PhoneNo,
                    Gender = customer.Gender,
                    Occupaation = customer.Occupaation,
                    IDType = customer.IDType,
                    IDNumber = customer.IDNumber,
                    IssueAuthority = customer.IssueAuthority,
                    IssuedState = customer.IssuedState,
                    IssuedDate = customer.IssuedDate,
                    ExpiryDate = customer.ExpiryDate,
                    AddressType = customer.AddressType,
                    Nationality = customer.Nationality,
                    District = customer.District,
                    State = customer.State,
                    BlockNumber = customer.BlockNumber,
                    Pincode = customer.Pincode,
                    GST = customer.GST,
                    PanNo = customer.PanNo,
                    OpeningBalance = customer.OpeningBalance,
                    BankName = customer.BankName,
                    BankAccNo = customer.BankAccNo,
                    IFSCCode = customer.IFSCCode,



                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(Addcustomer model)
        {
            var customer = await mvcDbContext.Customers.FindAsync(model.Id);
            if (customer != null)
            {
                customer.Name = model.Name;
                customer.DateofBirth = model.DateofBirth;
                customer.Email = model.Email;
                customer.PhoneNo = model.PhoneNo;
                customer.Gender = model.Gender;
                customer.Occupaation = model.Occupaation;
                customer.IDType = model.IDType;
                customer.IDNumber = model.IDNumber;
                customer.IssueAuthority = model.IssueAuthority;
                customer.IssuedState = model.IssuedState;
                customer.IssuedDate = model.IssuedDate;
                customer.ExpiryDate = model.ExpiryDate;
                customer.AddressType = model.AddressType;
                customer.Nationality = model.Nationality;
                customer.District = model.District;
                customer.State = model.State;
                customer.BlockNumber = model.BlockNumber;
                customer.Pincode = model.Pincode;
                customer.GST = model.GST;
                customer.PanNo = model.PanNo;
                customer.OpeningBalance = model.OpeningBalance;
                customer.BankName = model.BankName;
                customer.BankAccNo = model.BankAccNo;
                customer.IFSCCode = model.IFSCCode;



                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Addcustomer model)
        {
            var customer = await mvcDbContext.Customers.FindAsync(model.Id);

            if (customer != null)
            {
                mvcDbContext.Customers.Remove(customer);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


    }
}
