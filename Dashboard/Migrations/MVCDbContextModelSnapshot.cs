﻿// <auto-generated />
using Dashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dashboard.Migrations
{
    [DbContext(typeof(MVCDbContext))]
    partial class MVCDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dashboard.Models.Domain.Addsupplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupaation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupaation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupaation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupaation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Gst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("gsts");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BatchId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HSNCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemCodeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemIssuedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemManuDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemNameId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemPackedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandingCostId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MRPId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchasePriceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityWarning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RackColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalePriceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesDiscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B2BInvoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B2CInvoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatchNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cgst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Itemcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MRP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Particular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchasePrize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalePrize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sgst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Dashboard.Models.Domain.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
