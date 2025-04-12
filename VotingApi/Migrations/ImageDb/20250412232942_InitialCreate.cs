using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingApi.Migrations.ImageDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    imageId = table.Column<string>(type: "text", nullable: false),
                    imageData = table.Column<string>(type: "text", nullable: false),
                    voteCount = table.Column<int>(type: "integer", nullable: false),
                    winnerCount = table.Column<int>(type: "integer", nullable: false),
                    bracketId = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.imageId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
