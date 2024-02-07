using Microsoft.AspNetCore.Mvc;
using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace Dashboard.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly MVCDbContext mvcDbContext;

        public EmployeeController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await mvcDbContext.Employees.ToListAsync();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Addemployee addemployeeRequest)
        {
            var employee = new Employee
            {
                Id = addemployeeRequest.Id,
                Name = addemployeeRequest.Name,
                DateofBirth = addemployeeRequest.DateofBirth,
                Email = addemployeeRequest.Email,
                PhoneNo = addemployeeRequest.PhoneNo,
                Gender = addemployeeRequest.Gender,
                Occupaation = addemployeeRequest.Occupaation,
                IDType = addemployeeRequest.IDType,
                IDNumber = addemployeeRequest.IDNumber,
                IssueAuthority = addemployeeRequest.IssueAuthority,
                IssuedState = addemployeeRequest.IssuedState,
                IssuedDate = addemployeeRequest.IssuedDate,
                ExpiryDate = addemployeeRequest.ExpiryDate,
                AddressType = addemployeeRequest.AddressType,
                Nationality = addemployeeRequest.Nationality,
                District = addemployeeRequest.District,
                State = addemployeeRequest.State,
                BlockNumber = addemployeeRequest.BlockNumber,
                Pincode = addemployeeRequest.Pincode,
                GST = addemployeeRequest.GST,
                PanNo = addemployeeRequest.PanNo,
                OpeningBalance = addemployeeRequest.OpeningBalance,
                BankName = addemployeeRequest.BankName,
                BankAccNo = addemployeeRequest.BankAccNo,
                IFSCCode = addemployeeRequest.IFSCCode

            };
            await mvcDbContext.Employees.AddAsync(employee);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }

        public async Task<IActionResult> View(int id)
        {
            var employee = await mvcDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee != null)
            {
                var viewModel = new Addemployee()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    DateofBirth = employee.DateofBirth,
                    Email = employee.Email,
                    PhoneNo = employee.PhoneNo,
                    Gender = employee.Gender,
                    Occupaation = employee.Occupaation,
                    IDType = employee.IDType,
                    IDNumber = employee.IDNumber,
                    IssueAuthority = employee.IssueAuthority,
                    IssuedState = employee.IssuedState,
                    IssuedDate = employee.IssuedDate,
                    ExpiryDate = employee.ExpiryDate,
                    AddressType = employee.AddressType,
                    Nationality = employee.Nationality,
                    District = employee.District,
                    State = employee.State,
                    BlockNumber = employee.BlockNumber,
                    Pincode = employee.Pincode,
                    GST = employee.GST,
                    PanNo = employee.PanNo,
                    OpeningBalance = employee.OpeningBalance,
                    BankName = employee.BankName,
                    BankAccNo = employee.BankAccNo,
                    IFSCCode = employee.IFSCCode,



                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(Addemployee model)
        {
            var employee = await mvcDbContext.Employees.FindAsync(model.Id);
            if (employee != null)
            {
                employee.Name = model.Name;
                employee.DateofBirth = model.DateofBirth;
                employee.Email = model.Email;
                employee.PhoneNo = model.PhoneNo;
                employee.Gender = model.Gender;
                employee.Occupaation = model.Occupaation;
                employee.IDType = model.IDType;
                employee.IDNumber = model.IDNumber;
                employee.IssueAuthority = model.IssueAuthority;
                employee.IssuedState = model.IssuedState;
                employee.IssuedDate = model.IssuedDate;
                employee.ExpiryDate = model.ExpiryDate;
                employee.AddressType = model.AddressType;
                employee.Nationality = model.Nationality;
                employee.District = model.District;
                employee.State = model.State;
                employee.BlockNumber = model.BlockNumber;
                employee.Pincode = model.Pincode;
                employee.GST = model.GST;
                employee.PanNo = model.PanNo;
                employee.OpeningBalance = model.OpeningBalance;
                employee.BankName = model.BankName;
                employee.BankAccNo = model.BankAccNo;
                employee.IFSCCode = model.IFSCCode;



                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Addemployee model)
        {
            var employee = await mvcDbContext.Employees.FindAsync(model.Id);

            if (employee != null)
            {
                mvcDbContext.Employees.Remove(employee);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
