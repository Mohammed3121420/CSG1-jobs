using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobs.Migrations
{
    public partial class NewCluType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "dbsignUp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "dbsignUp");
        }
    }
}
