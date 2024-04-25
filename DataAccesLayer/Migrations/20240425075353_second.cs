using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_items_products_product_id",
                table: "product_items");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_category_id",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_receipt_items_products_product_id",
                table: "receipt_items");

            migrationBuilder.DropForeignKey(
                name: "FK_receipt_items_receipts_receipt_id",
                table: "receipt_items");

            migrationBuilder.DropForeignKey(
                name: "FK_receipts_branchs_branch_id",
                table: "receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_user_user_role_RoleId",
                table: "user");

            migrationBuilder.AddForeignKey(
                name: "FK_product_items_products_product_id",
                table: "product_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_category_id",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_receipt_items_products_product_id",
                table: "receipt_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_receipt_items_receipts_receipt_id",
                table: "receipt_items",
                column: "receipt_id",
                principalTable: "receipts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_receipts_branchs_branch_id",
                table: "receipts",
                column: "branch_id",
                principalTable: "branchs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_user_role_RoleId",
                table: "user",
                column: "RoleId",
                principalTable: "user_role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_items_products_product_id",
                table: "product_items");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_category_id",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_receipt_items_products_product_id",
                table: "receipt_items");

            migrationBuilder.DropForeignKey(
                name: "FK_receipt_items_receipts_receipt_id",
                table: "receipt_items");

            migrationBuilder.DropForeignKey(
                name: "FK_receipts_branchs_branch_id",
                table: "receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_user_user_role_RoleId",
                table: "user");

            migrationBuilder.AddForeignKey(
                name: "FK_product_items_products_product_id",
                table: "product_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_category_id",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_receipt_items_products_product_id",
                table: "receipt_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_receipt_items_receipts_receipt_id",
                table: "receipt_items",
                column: "receipt_id",
                principalTable: "receipts",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_receipts_branchs_branch_id",
                table: "receipts",
                column: "branch_id",
                principalTable: "branchs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_user_role_RoleId",
                table: "user",
                column: "RoleId",
                principalTable: "user_role",
                principalColumn: "id");
        }
    }
}
