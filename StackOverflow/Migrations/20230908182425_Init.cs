using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace StackOverflow.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Badges_UserId",
                table: "Badges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLinks_LinkTypeId",
                table: "PostLinks",
                column: "LinkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLinks_PostId",
                table: "PostLinks",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLinks_RelatedPostId",
                table: "PostLinks",
                column: "RelatedPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_OwnerUserId",
                table: "Posts",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ParentId",
                table: "Posts",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTypeId",
                table: "Posts",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PostId",
                table: "Votes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoteTypeId",
                table: "Votes",
                column: "VoteTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
