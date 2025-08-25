using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connectOracleDBTest.Migrations
{
    /// <inheritdoc />
    public partial class FixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "VIETHADEV");

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                schema: "VIETHADEV",
                columns: table => new
                {
                    CUSTOMER_ID = table.Column<string>(type: "VARCHAR2(64)", nullable: false),
                    FULL_NAME = table.Column<string>(type: "VARCHAR2(20 BYTE)", nullable: false),
                    PHONE_NUMBER = table.Column<string>(type: "VARCHAR2(20 BYTE)", nullable: false),
                    GENDER = table.Column<int>(type: "NUMBER(1,0)", nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR2(25 BYTE)", nullable: false),
                    OFFSET = table.Column<long>(type: "NUMBER(19,0)", nullable: false),
                    PARTITION = table.Column<short>(type: "NUMBER(5,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.CUSTOMER_ID);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                schema: "VIETHADEV",
                columns: table => new
                {
                    ORDER_ID = table.Column<string>(type: "VARCHAR2(64)", nullable: false),
                    TOTAL_AMOUNT = table.Column<decimal>(type: "NUMBER(8,2)", nullable: false),
                    STATUS = table.Column<int>(type: "NUMBER(1,0)", nullable: false),
                    CUSTOMER_ID = table.Column<string>(type: "VARCHAR2(64)", nullable: false),
                    PRODUCT_ID = table.Column<string>(type: "VARCHAR2(64)", nullable: false),
                    OFFSET = table.Column<long>(type: "NUMBER(19,0)", nullable: false),
                    PARTITION = table.Column<short>(type: "NUMBER(5,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.ORDER_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                schema: "VIETHADEV",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<string>(type: "VARCHAR2(64)", nullable: false),
                    PRODUCT_NAME = table.Column<string>(type: "VARCHAR2(20 BYTE)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(50 BYTE)", nullable: false),
                    PRICE = table.Column<decimal>(type: "NUMBER(8,2)", nullable: false),
                    QUANTITY = table.Column<int>(type: "NUMBER(8,0)", nullable: false),
                    OFFSET = table.Column<long>(type: "NUMBER(19,0)", nullable: false),
                    PARTITION = table.Column<short>(type: "NUMBER(5,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.PRODUCT_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CUSTOMER",
                schema: "VIETHADEV");

            migrationBuilder.DropTable(
                name: "ORDERS",
                schema: "VIETHADEV");

            migrationBuilder.DropTable(
                name: "PRODUCT",
                schema: "VIETHADEV");
        }
    }
}
