using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodControl.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:FoodControl/Migrations/20231102164319_first migration.cs
    public partial class firstmigration : Migration
========
    public partial class firstmig : Migration
>>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7:FoodControl/Migrations/20231102015753_firstmig.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbDogTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Food = table.Column<int>(type: "INTEGER", nullable: false),
                    MissingFood = table.Column<int>(type: "INTEGER", nullable: false),
                    Water = table.Column<int>(type: "INTEGER", nullable: false),
                    MissingWater = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDogTreatments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbDogTreatments");
        }
    }
}
