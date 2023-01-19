using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SesaPay.DataModels.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_cities",
                columns: table => new
                {
                    cityid = table.Column<int>(name: "city_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cityname = table.Column<string>(name: "city_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stateid = table.Column<int>(name: "state_id", type: "int", nullable: false),
                    countryid = table.Column<int>(name: "country_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cities", x => x.cityid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_Partners",
                columns: table => new
                {
                    partnerid = table.Column<int>(name: "partner_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    partnername = table.Column<string>(name: "partner_name", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    partneroperator = table.Column<string>(name: "partner_operator", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    partneremail = table.Column<string>(name: "partner_email", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    partnerphonecode = table.Column<int>(name: "partner_phone_code", type: "int", nullable: false),
                    partnermobilenumber = table.Column<int>(name: "partner_mobile_number", type: "int", nullable: false),
                    partnerpassword = table.Column<string>(name: "partner_password", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Partners", x => x.partnerid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_cities");

            migrationBuilder.DropTable(
                name: "tbl_Partners");
        }
    }
}
