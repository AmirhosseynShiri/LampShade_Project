using Microsoft.EntityFrameworkCore.Migrations;

namespace ShioManagement.Infrastructure.EfCore.Migrations
{
    public partial class modified_piture_to_Picture_InproductPictureEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Piture",
                table: "ProductPictures",
                newName: "Picture");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "ProductPictures",
                newName: "Piture");
        }
    }
}
