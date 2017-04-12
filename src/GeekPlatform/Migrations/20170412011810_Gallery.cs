using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeekPlatform.Migrations
{
    public partial class Gallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GalleryAlbum",
                columns: table => new
                {
                    GalleryAlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryAlbum", x => x.GalleryAlbumId);
                    table.ForeignKey(
                        name: "FK_GalleryAlbum_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GalleryPicture",
                columns: table => new
                {
                    GalleryPictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(nullable: true),
                    Filename = table.Column<string>(nullable: true),
                    GalleryAlbumId = table.Column<int>(nullable: false),
                    UploadedAt = table.Column<DateTime>(nullable: false),
                    UploaderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryPicture", x => x.GalleryPictureId);
                    table.ForeignKey(
                        name: "FK_GalleryPicture_GalleryAlbum_GalleryAlbumId",
                        column: x => x.GalleryAlbumId,
                        principalTable: "GalleryAlbum",
                        principalColumn: "GalleryAlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryPicture_AspNetUsers_UploaderId",
                        column: x => x.UploaderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryAlbum_CreatorId",
                table: "GalleryAlbum",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryPicture_GalleryAlbumId",
                table: "GalleryPicture",
                column: "GalleryAlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryPicture_UploaderId",
                table: "GalleryPicture",
                column: "UploaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryPicture");

            migrationBuilder.DropTable(
                name: "GalleryAlbum");
        }
    }
}
