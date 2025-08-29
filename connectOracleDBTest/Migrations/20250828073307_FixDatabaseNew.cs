using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connectOracleDBTest.Migrations
{
    /// <inheritdoc />
    public partial class FixDatabaseNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PRODUCT_ID",
                schema: "VIETHADEV",
                table: "ORDERS",
                type: "VARCHAR2(64)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(5 BYTE)");

            migrationBuilder.AlterColumn<string>(
                name: "CUSTOMER_ID",
                schema: "VIETHADEV",
                table: "ORDERS",
                type: "VARCHAR2(64)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(5 BYTE)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PRODUCT_ID",
                schema: "VIETHADEV",
                table: "ORDERS",
                type: "VARCHAR2(5 BYTE)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(64)");

            migrationBuilder.AlterColumn<string>(
                name: "CUSTOMER_ID",
                schema: "VIETHADEV",
                table: "ORDERS",
                type: "VARCHAR2(5 BYTE)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(64)");
        }
    }
}
