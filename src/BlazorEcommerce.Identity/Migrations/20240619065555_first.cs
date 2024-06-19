using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Identity.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "222c5675-7803-4717-8d10-ab1a7c69e052", "AQAAAAIAAYagAAAAECf5h79uwqtJNtCLZQFfQFyRcSGVrULUgKe3LmwBd2nUEKIOwRnDMKlkZ0wciEDlQA==", "07c9fa9d-38d5-4f2d-9371-c2bde4ba0086" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e5558c-8443-471c-add5-facbbd4d290d", "AQAAAAIAAYagAAAAEPURuIpj7YvvBDIjSWUp3vIbMweVGDjd/51OTeO0W3jJxGY0DRWw6IaFj/uB7JqVzg==", "56c284bf-f2ab-4fa2-b7e9-710098cb62a0" });
        }
    }
}
