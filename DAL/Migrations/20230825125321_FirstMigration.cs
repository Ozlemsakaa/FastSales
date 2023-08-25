using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTransactionType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TurnNumber = table.Column<short>(type: "smallint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencys",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuss",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    N11Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HepsiburadaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrendyolName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GittiGidiyorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WoocommerceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AmazonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AliexpressName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    N11DetailName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrestaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CssClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSkuPriceTypes",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSkuPriceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitTypes",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficialName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyTypeId = table.Column<short>(type: "smallint", nullable: false),
                    CompanyClassId = table.Column<short>(type: "smallint", nullable: true),
                    CompanyInvoiceId = table.Column<int>(type: "int", nullable: true),
                    CompanyFinanceId = table.Column<int>(type: "int", nullable: true),
                    CompanyAccountIntegratorId = table.Column<int>(type: "int", nullable: true),
                    AccountProgram = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companys_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    AccountTypeId = table.Column<short>(type: "smallint", nullable: true),
                    CurrencyId = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAmount = table.Column<double>(type: "float", nullable: true),
                    BranchCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AccountNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Iban = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: true),
                    BankId = table.Column<short>(type: "smallint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountDefinition_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountDefinition_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountDefinition_Currencys_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FormattedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MetaKeyWords = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WebId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Brands_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeLength = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    FormattedName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FullPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeep = table.Column<bool>(type: "bit", nullable: true),
                    IsFastSelling = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ProductOrder = table.Column<int>(type: "int", nullable: true),
                    WebId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorys_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categorys_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShortTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectorId = table.Column<short>(type: "smallint", nullable: true),
                    CustomerInvoiceId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CustomerFinanceId = table.Column<int>(type: "int", nullable: true),
                    CustomerPresentativeId = table.Column<int>(type: "int", nullable: true),
                    SalesPresentativeId = table.Column<int>(type: "int", nullable: true),
                    MatchCustomerId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceCustomerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AccountCustomerMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    UserTypeId = table.Column<short>(type: "smallint", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AccountDefinitionId = table.Column<int>(type: "int", nullable: false),
                    AccountTransactionTypeId = table.Column<short>(type: "smallint", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptAmount = table.Column<double>(type: "float", nullable: true),
                    CreditorAmount = table.Column<double>(type: "float", nullable: true),
                    CurrencyTypeId = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TransferAccountId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransactionId = table.Column<int>(type: "int", nullable: true),
                    ReceiveId = table.Column<int>(type: "int", nullable: true),
                    TransferId = table.Column<int>(type: "int", nullable: true),
                    OutGoingId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransferId = table.Column<int>(type: "int", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    PersonelTransactionId = table.Column<int>(type: "int", nullable: true),
                    ChequeId = table.Column<int>(type: "int", nullable: true),
                    BondId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    OutgoingsEntryId = table.Column<int>(type: "int", nullable: true),
                    OutgoingsCategoryId = table.Column<int>(type: "int", nullable: true),
                    PaymentInstallmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_AccountDefinition_AccountDefinitionId",
                        column: x => x.AccountDefinitionId,
                        principalTable: "AccountDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_AccountTransactionType_AccountTransactionTypeId",
                        column: x => x.AccountTransactionTypeId,
                        principalTable: "AccountTransactionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Currencys_CurrencyTypeId",
                        column: x => x.CurrencyTypeId,
                        principalTable: "Currencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    InvoicTaxTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BasketStatus = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountType = table.Column<short>(type: "smallint", nullable: false),
                    Notes = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Baskets_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Baskets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderStatusId = table.Column<short>(type: "smallint", nullable: false),
                    OrderMarketPlaceStatusId = table.Column<short>(type: "smallint", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceBarcodeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SalesSlipStatus = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceStatus = table.Column<bool>(type: "bit", nullable: false),
                    GiftCardStatus = table.Column<bool>(type: "bit", nullable: false),
                    CargoBarcodeStatus = table.Column<bool>(type: "bit", nullable: false),
                    MarketPlaceOrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceStoreId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EInvoiceId = table.Column<int>(type: "int", nullable: true),
                    EArchiveId = table.Column<int>(type: "int", nullable: true),
                    EDocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EArchiveCancelled = table.Column<bool>(type: "bit", nullable: false),
                    AccountingTransfer = table.Column<bool>(type: "bit", nullable: false),
                    IsSentMail = table.Column<bool>(type: "bit", nullable: true),
                    IsWrittenInvoice = table.Column<bool>(type: "bit", nullable: true),
                    IsInvoicedFromPortal = table.Column<bool>(type: "bit", nullable: true),
                    Ettn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCargoOrderCreated = table.Column<bool>(type: "bit", nullable: true),
                    IsCargoOrderCancelled = table.Column<bool>(type: "bit", nullable: true),
                    IsCargoReturnOrderCreated = table.Column<bool>(type: "bit", nullable: true),
                    CargoOrderNumber = table.Column<int>(type: "int", nullable: true),
                    CargoApproval = table.Column<bool>(type: "bit", nullable: true),
                    CargoResultKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsInvoiceSuccessfull = table.Column<bool>(type: "bit", nullable: true),
                    AccountOrderMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuss_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnOrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderStatusId = table.Column<short>(type: "smallint", nullable: false),
                    OrderMarketPlaceStatusId = table.Column<short>(type: "smallint", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceBarcodeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SalesSlipStatus = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceStatus = table.Column<bool>(type: "bit", nullable: false),
                    GiftCardStatus = table.Column<bool>(type: "bit", nullable: false),
                    CargoBarcodeStatus = table.Column<bool>(type: "bit", nullable: false),
                    MarketPlaceOrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceStoreId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EInvoiceId = table.Column<int>(type: "int", nullable: true),
                    EArchiveId = table.Column<int>(type: "int", nullable: true),
                    EDocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EArchiveCancelled = table.Column<bool>(type: "bit", nullable: false),
                    AccountingTransfer = table.Column<bool>(type: "bit", nullable: false),
                    IsSentMail = table.Column<bool>(type: "bit", nullable: true),
                    IsWrittenInvoice = table.Column<bool>(type: "bit", nullable: true),
                    IsInvoicedFromPortal = table.Column<bool>(type: "bit", nullable: true),
                    Ettn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCargoOrderCreated = table.Column<bool>(type: "bit", nullable: true),
                    IsCargoOrderCancelled = table.Column<bool>(type: "bit", nullable: true),
                    IsCargoReturnOrderCreated = table.Column<bool>(type: "bit", nullable: true),
                    CargoOrderNumber = table.Column<int>(type: "int", nullable: true),
                    CargoApproval = table.Column<bool>(type: "bit", nullable: true),
                    CargoResultKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsInvoiceSuccessfull = table.Column<bool>(type: "bit", nullable: true),
                    AccountOrderMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_OrderStatuss_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FormattedName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WebId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsVariants = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAttributes_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAttributes_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAttributes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupCode = table.Column<short>(type: "smallint", nullable: true),
                    GtipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GtinNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    InvoiceTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsBundle = table.Column<bool>(type: "bit", nullable: false),
                    IsVariant = table.Column<bool>(type: "bit", nullable: false),
                    KabPackagingCodeId = table.Column<short>(type: "smallint", nullable: true),
                    MainCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PurchaseVat = table.Column<int>(type: "int", nullable: true),
                    SalesVat = table.Column<int>(type: "int", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitTypeId = table.Column<short>(type: "smallint", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Currencys_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FormattedName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyAttributeId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    WebId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAttributeValues_CompanyAttributes_CompanyAttributeId",
                        column: x => x.CompanyAttributeId,
                        principalTable: "CompanyAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAttributeValues_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSkus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTransfered = table.Column<bool>(type: "bit", nullable: true),
                    AccountTransferedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    Desi = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPriceChange = table.Column<bool>(type: "bit", nullable: false),
                    IsSaleWithOutStock = table.Column<bool>(type: "bit", nullable: false),
                    IsSaleWithOutStockQuantity = table.Column<int>(type: "int", nullable: true),
                    IsStockChange = table.Column<bool>(type: "bit", nullable: false),
                    LastPriceUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastStockUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaxStock = table.Column<int>(type: "int", nullable: true),
                    MinStock = table.Column<int>(type: "int", nullable: true),
                    Mpn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductionYear = table.Column<int>(type: "int", nullable: true),
                    PurchaseSize = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    ReservQuantity = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    ShelfNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StockCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    VariantPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WarrantyPeriodMonth = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSkus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSkus_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSkus_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSkus_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSkus_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyAttributeId = table.Column<int>(type: "int", nullable: false),
                    CompanyAttributeValueId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_CompanyAttributes_CompanyAttributeId",
                        column: x => x.CompanyAttributeId,
                        principalTable: "CompanyAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_CompanyAttributeValues_CompanyAttributeValueId",
                        column: x => x.CompanyAttributeValueId,
                        principalTable: "CompanyAttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    ProductSkuId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTypeId = table.Column<short>(type: "smallint", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ctimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rtimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockName = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_ProductSkus_ProductSkuId",
                        column: x => x.ProductSkuId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    OrderDetailDeliveryInfoId = table.Column<int>(type: "int", nullable: true),
                    CargoCompanyId = table.Column<short>(type: "smallint", nullable: true),
                    CargoTrackingNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CargoTrackingUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CargoPaymentInfo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoBarcodeImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PackageNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DetailStatusId = table.Column<short>(type: "smallint", nullable: true),
                    DetailMarketPlaceStatusId = table.Column<short>(type: "smallint", nullable: true),
                    SalesCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductSku = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductSkusId = table.Column<int>(type: "int", nullable: true),
                    StoreProductId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceSku = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CargoPrice = table.Column<double>(type: "float", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: true),
                    UnitDiscount = table.Column<double>(type: "float", nullable: true),
                    LineTotalPrice = table.Column<double>(type: "float", nullable: true),
                    LineDiscountPrice = table.Column<double>(type: "float", nullable: true),
                    UnitNetPrice = table.Column<double>(type: "float", nullable: true),
                    LineNetPrice = table.Column<double>(type: "float", nullable: true),
                    MaturityDifference = table.Column<double>(type: "float", nullable: true),
                    SellerCouponDiscount = table.Column<double>(type: "float", nullable: true),
                    SellerDiscount = table.Column<double>(type: "float", nullable: true),
                    SellerInvoicePrice = table.Column<double>(type: "float", nullable: true),
                    Commission = table.Column<double>(type: "float", nullable: true),
                    VatRate = table.Column<int>(type: "int", nullable: true),
                    Vat = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SapNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommissionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoDeliveryTime = table.Column<int>(type: "int", nullable: true),
                    CargoArrivalTime = table.Column<int>(type: "int", nullable: true),
                    PaymentDueTime = table.Column<int>(type: "int", nullable: true),
                    DeliveryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceLineId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gtip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Desi = table.Column<double>(type: "float", nullable: true),
                    EInvoiceId = table.Column<int>(type: "int", nullable: true),
                    EArchiveId = table.Column<int>(type: "int", nullable: true),
                    RequestedDeliveryDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantityUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsLateToCargo = table.Column<bool>(type: "bit", nullable: true),
                    CardMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTransactionCreditorId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransactionDeptId = table.Column<int>(type: "int", nullable: true),
                    AccountTransactionId = table.Column<int>(type: "int", nullable: true),
                    LineType = table.Column<int>(type: "int", nullable: true),
                    AccountOrderDetailMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderStatuss_DetailStatusId",
                        column: x => x.DetailStatusId,
                        principalTable: "OrderStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductSkus_ProductSkusId",
                        column: x => x.ProductSkusId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSkuImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSkuId = table.Column<int>(type: "int", nullable: true),
                    ProductImageId = table.Column<int>(type: "int", nullable: true),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSkuImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSkuImages_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSkuImages_ProductSkus_ProductSkuId",
                        column: x => x.ProductSkuId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSkuPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    ProductSkuPriceTypeId = table.Column<short>(type: "smallint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ProductSkuId = table.Column<int>(type: "int", nullable: false),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSkuPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSkuPrices_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSkuPrices_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSkuPrices_ProductSkuPriceTypes_ProductSkuPriceTypeId",
                        column: x => x.ProductSkuPriceTypeId,
                        principalTable: "ProductSkuPriceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSkuPrices_ProductSkus_ProductSkuId",
                        column: x => x.ProductSkuId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSkuVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSkuId = table.Column<int>(type: "int", nullable: false),
                    CompanyAttributeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CompanyAttributeValueId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    IsVariant = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSkuVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSkuVariants_CompanyAttributes_CompanyAttributeId",
                        column: x => x.CompanyAttributeId,
                        principalTable: "CompanyAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSkuVariants_CompanyAttributeValues_CompanyAttributeValueId",
                        column: x => x.CompanyAttributeValueId,
                        principalTable: "CompanyAttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSkuVariants_ProductSkus_ProductSkuId",
                        column: x => x.ProductSkuId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ReturnOrderId = table.Column<int>(type: "int", nullable: true),
                    OrderDetailDeliveryInfoId = table.Column<int>(type: "int", nullable: true),
                    CargoCompanyId = table.Column<short>(type: "smallint", nullable: true),
                    CargoTrackingNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CargoTrackingUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CargoPaymentInfo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoBarcodeImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PackageNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DetailStatusId = table.Column<short>(type: "smallint", nullable: true),
                    DetailMarketPlaceStatusId = table.Column<short>(type: "smallint", nullable: true),
                    SalesCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductSku = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductSkusId = table.Column<int>(type: "int", nullable: true),
                    StoreProductId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceSku = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CargoPrice = table.Column<double>(type: "float", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: true),
                    UnitDiscount = table.Column<double>(type: "float", nullable: true),
                    LineTotalPrice = table.Column<double>(type: "float", nullable: true),
                    LineDiscountPrice = table.Column<double>(type: "float", nullable: true),
                    UnitNetPrice = table.Column<double>(type: "float", nullable: true),
                    LineNetPrice = table.Column<double>(type: "float", nullable: true),
                    MaturityDifference = table.Column<double>(type: "float", nullable: true),
                    SellerCouponDiscount = table.Column<double>(type: "float", nullable: true),
                    SellerDiscount = table.Column<double>(type: "float", nullable: true),
                    SellerInvoicePrice = table.Column<double>(type: "float", nullable: true),
                    Commission = table.Column<double>(type: "float", nullable: true),
                    VatRate = table.Column<int>(type: "int", nullable: true),
                    Vat = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SapNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommissionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoDeliveryTime = table.Column<int>(type: "int", nullable: true),
                    CargoArrivalTime = table.Column<int>(type: "int", nullable: true),
                    PaymentDueTime = table.Column<int>(type: "int", nullable: true),
                    DeliveryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceLineId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gtip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Desi = table.Column<double>(type: "float", nullable: true),
                    EInvoiceId = table.Column<int>(type: "int", nullable: true),
                    EArchiveId = table.Column<int>(type: "int", nullable: true),
                    RequestedDeliveryDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantityUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsLateToCargo = table.Column<bool>(type: "bit", nullable: true),
                    CardMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTransactionCreditorId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransactionDeptId = table.Column<int>(type: "int", nullable: true),
                    AccountTransactionId = table.Column<int>(type: "int", nullable: true),
                    LineType = table.Column<int>(type: "int", nullable: true),
                    AccountOrderDetailMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetail_OrderStatuss_DetailStatusId",
                        column: x => x.DetailStatusId,
                        principalTable: "OrderStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetail_ProductSkus_ProductSkusId",
                        column: x => x.ProductSkusId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetail_ReturnOrder_ReturnOrderId",
                        column: x => x.ReturnOrderId,
                        principalTable: "ReturnOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetailAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReturnOrderDetailId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetailAttributes_OrderDetails_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetailAttributes_ReturnOrderDetail_ReturnOrderDetailId",
                        column: x => x.ReturnOrderDetailId,
                        principalTable: "ReturnOrderDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountDefinition_AccountTypeId",
                table: "AccountDefinition",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountDefinition_CompanyId",
                table: "AccountDefinition",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountDefinition_CurrencyId",
                table: "AccountDefinition",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_AccountDefinitionId",
                table: "AccountTransaction",
                column: "AccountDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_AccountTransactionTypeId",
                table: "AccountTransaction",
                column: "AccountTransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_CompanyId",
                table: "AccountTransaction",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_CurrencyTypeId",
                table: "AccountTransaction",
                column: "CurrencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_CustomerId",
                table: "AccountTransaction",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_BasketId",
                table: "BasketDetails",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_ProductSkuId",
                table: "BasketDetails",
                column: "ProductSkuId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_UnitTypeId",
                table: "BasketDetails",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CompanyGroupId",
                table: "Baskets",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CompanyId",
                table: "Baskets",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CustomerId",
                table: "Baskets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CompanyGroupId",
                table: "Brands",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CompanyId",
                table: "Brands",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_CompanyGroupId",
                table: "Categorys",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_CompanyId",
                table: "Categorys",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAttributes_CompanyGroupId",
                table: "CompanyAttributes",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAttributes_CompanyId",
                table: "CompanyAttributes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAttributes_UserId",
                table: "CompanyAttributes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAttributeValues_CompanyAttributeId",
                table: "CompanyAttributeValues",
                column: "CompanyAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAttributeValues_UserId",
                table: "CompanyAttributeValues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Companys_CompanyGroupId",
                table: "Companys",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyGroupId",
                table: "Customers",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyId",
                table: "Customers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailAttributes_OrderDetailId",
                table: "OrderDetailAttributes",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailAttributes_ReturnOrderDetailId",
                table: "OrderDetailAttributes",
                column: "ReturnOrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DetailStatusId",
                table: "OrderDetails",
                column: "DetailStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductSkusId",
                table: "OrderDetails",
                column: "ProductSkusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CompanyGroupId",
                table: "Orders",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CompanyId",
                table: "Orders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_CompanyAttributeId",
                table: "ProductAttributes",
                column: "CompanyAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_CompanyAttributeValueId",
                table: "ProductAttributes",
                column: "CompanyAttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CompanyId",
                table: "ProductImages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyGroupId",
                table: "Products",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CurrencyId",
                table: "Products",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuImages_ProductImageId",
                table: "ProductSkuImages",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuImages_ProductSkuId",
                table: "ProductSkuImages",
                column: "ProductSkuId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuPrices_CompanyGroupId",
                table: "ProductSkuPrices",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuPrices_CompanyId",
                table: "ProductSkuPrices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuPrices_ProductSkuId",
                table: "ProductSkuPrices",
                column: "ProductSkuId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuPrices_ProductSkuPriceTypeId",
                table: "ProductSkuPrices",
                column: "ProductSkuPriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkus_CompanyGroupId",
                table: "ProductSkus",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkus_CompanyId",
                table: "ProductSkus",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkus_ProductId",
                table: "ProductSkus",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkus_UserId",
                table: "ProductSkus",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuVariants_CompanyAttributeId",
                table: "ProductSkuVariants",
                column: "CompanyAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuVariants_CompanyAttributeValueId",
                table: "ProductSkuVariants",
                column: "CompanyAttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSkuVariants_ProductSkuId",
                table: "ProductSkuVariants",
                column: "ProductSkuId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_CompanyGroupId",
                table: "ReturnOrder",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_CompanyId",
                table: "ReturnOrder",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_CustomerId",
                table: "ReturnOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_OrderStatusId",
                table: "ReturnOrder",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetail_DetailStatusId",
                table: "ReturnOrderDetail",
                column: "DetailStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetail_ProductSkusId",
                table: "ReturnOrderDetail",
                column: "ProductSkusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetail_ReturnOrderId",
                table: "ReturnOrderDetail",
                column: "ReturnOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyGroupId",
                table: "Users",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTransaction");

            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "OrderDetailAttributes");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "ProductSkuImages");

            migrationBuilder.DropTable(
                name: "ProductSkuPrices");

            migrationBuilder.DropTable(
                name: "ProductSkuVariants");

            migrationBuilder.DropTable(
                name: "AccountDefinition");

            migrationBuilder.DropTable(
                name: "AccountTransactionType");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ReturnOrderDetail");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductSkuPriceTypes");

            migrationBuilder.DropTable(
                name: "CompanyAttributeValues");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductSkus");

            migrationBuilder.DropTable(
                name: "ReturnOrder");

            migrationBuilder.DropTable(
                name: "CompanyAttributes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatuss");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Currencys");

            migrationBuilder.DropTable(
                name: "UnitTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "CompanyGroups");
        }
    }
}
