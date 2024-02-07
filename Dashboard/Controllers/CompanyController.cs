using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;
using Dashboard.Data;
using Dashboard.Models.Domain;
using Dashboard.Models;
using System.Runtime.Intrinsics.Arm;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Components.Web.Virtualization;
namespace Dashboard.Controllers
{
    public class CompanyController : Controller
    {
        
            private readonly MVCDbContext mvcDbContext;

            public CompanyController(MVCDbContext mvcDbContext)
            {
                this.mvcDbContext = mvcDbContext;
            }

            [HttpGet]
            public async Task<IActionResult> Index()
            {
                var companies = await mvcDbContext.Companies.ToListAsync();
                return View(companies);
            }

            [HttpGet]
            public IActionResult Add()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Add(Addcompany addcompanyRequest)
            {
                var company = new Company()
                {
                    Id = addcompanyRequest.Id,
                    Name = addcompanyRequest.Name,
                    DateofBirth = addcompanyRequest.DateofBirth,
                    Email = addcompanyRequest.Email,
                    PhoneNo = addcompanyRequest.PhoneNo,
                    Gender = addcompanyRequest.Gender,
                    Occupaation = addcompanyRequest.Occupaation,
                    IDType = addcompanyRequest.IDType,
                    IDNumber = addcompanyRequest.IDNumber,
                    IssueAuthority = addcompanyRequest.IssueAuthority,
                    IssuedState = addcompanyRequest.IssuedState,
                    IssuedDate = addcompanyRequest.IssuedDate,
                    ExpiryDate = addcompanyRequest.ExpiryDate,
                    AddressType = addcompanyRequest.AddressType,
                    Nationality = addcompanyRequest.Nationality,
                    District = addcompanyRequest.District,
                    State = addcompanyRequest.State,
                    BlockNumber = addcompanyRequest.BlockNumber,
                    Pincode = addcompanyRequest.Pincode,
                    GST = addcompanyRequest.GST,
                    PanNo = addcompanyRequest.PanNo,
                    OpeningBalance = addcompanyRequest.OpeningBalance,
                    BankName = addcompanyRequest.BankName,
                    BankAccNo = addcompanyRequest.BankAccNo,
                    IFSCCode = addcompanyRequest.IFSCCode

                };

                await mvcDbContext.Companies.AddAsync(company);
                await mvcDbContext.SaveChangesAsync();
                return RedirectToAction("Add");
            }
            public async Task<IActionResult> View(int id)
            {
                var company = await mvcDbContext.Companies.FirstOrDefaultAsync(x => x.Id == id);

                if (company != null)
                {
                    var viewModel = new Addcompany()
                    {
                        Id = company.Id,
                        Name = company.Name,
                        DateofBirth = company.DateofBirth,
                        Email = company.Email,
                        PhoneNo = company.PhoneNo,
                        Gender = company.Gender,
                        Occupaation = company.Occupaation,
                        IDType = company.IDType,
                        IDNumber = company.IDNumber,
                        IssueAuthority = company.IssueAuthority,
                        IssuedState = company.IssuedState,
                        IssuedDate = company.IssuedDate,
                        ExpiryDate = company.ExpiryDate,
                        AddressType = company.AddressType,
                        Nationality = company.Nationality,
                        District = company.District,
                        State = company.State,
                        BlockNumber = company.BlockNumber,
                        Pincode = company.Pincode,
                        GST = company.GST,
                        PanNo = company.PanNo,
                        OpeningBalance = company.OpeningBalance,
                        BankName = company.BankName,
                        BankAccNo = company.BankAccNo,
                        IFSCCode = company.IFSCCode,
                        


                    };
                    return await Task.Run(() => View("View", (viewModel)));
                }

                return RedirectToAction("Index");
            }
            [HttpPost]
            public async Task<IActionResult> View(Addcompany model)
            {
                var company = await mvcDbContext.Companies.FindAsync(model.Id);
                if (company != null)
                {
                    company.Name = model.Name;
                    company.DateofBirth = model.DateofBirth;
                    company.Email = model.Email;
                    company.PhoneNo = model.PhoneNo;
                    company.Gender = model.Gender;
                    company.Occupaation = model.Occupaation;
                    company.IDType = model.IDType;
                    company.IDNumber = model.IDNumber;
                    company.IssueAuthority = model.IssueAuthority;
                    company.IssuedState = model.IssuedState;
                    company.IssuedDate = model.IssuedDate;
                    company.ExpiryDate = model.ExpiryDate;
                    company.AddressType = model.AddressType;
                    company.Nationality = model.Nationality;
                    company.District = model.District;
                    company.State = model.State;
                    company.BlockNumber = model.BlockNumber;
                    company.Pincode = model.Pincode;
                    company.GST = model.GST;
                    company.PanNo = model.PanNo;
                    company.OpeningBalance = model.OpeningBalance;
                    company.BankName = model.BankName;
                    company.BankAccNo = model.BankAccNo;
                    company.IFSCCode = model.IFSCCode;



                    await mvcDbContext.SaveChangesAsync();

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            [HttpPost]
            public async Task<IActionResult> Delete(Addcompany model)
            {
                var company = await mvcDbContext.Companies.FindAsync(model.Id);

                if (company != null)
                {
                    mvcDbContext.Companies.Remove(company);
                    await mvcDbContext.SaveChangesAsync();

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
        
    }
}
