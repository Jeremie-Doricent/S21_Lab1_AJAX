using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using ZombieParty.Models.Data;

#nullable disable

namespace ZombieParty.Migrations
{
    [DbContext(typeof(ZombiePartyDbContext))]
    [Migration("20231107210000_AjoutZombieIsFavorite")]
    public partial class AjoutZombieIsFavorite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Zombies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Zombies");
        }
    }
}
