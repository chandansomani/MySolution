using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustFK2Inv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomerID",
                table: "Invoice",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Customer_CustomerID",
                table: "Invoice",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Customer_CustomerID",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_CustomerID",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Invoice");
        }
    }
}
