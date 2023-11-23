using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sample1.Migrations
{
    /// <inheritdoc />
    public partial class newcolumnaddedmigrationwithapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "location_id",
                table: "Dept",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location_id",
                table: "Dept");
        }
    }
}
