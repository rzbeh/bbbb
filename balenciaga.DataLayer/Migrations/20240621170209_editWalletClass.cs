﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace balenciaga.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class editWalletClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_walletTypes_WalletTypeTypeId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_WalletTypeTypeId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "WalletTypeTypeId",
                table: "Wallets");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_TypeId",
                table: "Wallets",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_walletTypes_TypeId",
                table: "Wallets",
                column: "TypeId",
                principalTable: "walletTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_walletTypes_TypeId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_TypeId",
                table: "Wallets");

            migrationBuilder.AddColumn<int>(
                name: "WalletTypeTypeId",
                table: "Wallets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_WalletTypeTypeId",
                table: "Wallets",
                column: "WalletTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_walletTypes_WalletTypeTypeId",
                table: "Wallets",
                column: "WalletTypeTypeId",
                principalTable: "walletTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
