using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv.Domain.Migrations
{
    public partial class BlogComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "BlogPostComments");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "BlogPosts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostId",
                table: "BlogPostComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "BlogPostComments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "BlogPostComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CreatedByUserId",
                table: "BlogPosts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_CreatedByUserId",
                table: "BlogPostComments",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId",
                table: "BlogPostComments",
                column: "CreatedByUserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Users_CreatedByUserId",
                table: "BlogPosts",
                column: "CreatedByUserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Users_CreatedByUserId",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_CreatedByUserId",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostComments_CreatedByUserId",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "BlogPostComments");

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostId",
                table: "BlogPostComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "BlogPostComments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "BlogPostComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
