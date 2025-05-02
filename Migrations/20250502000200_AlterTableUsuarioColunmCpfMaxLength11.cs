using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookRate.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableUsuarioColunmCpfMaxLength11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "USUARIO",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(9)",
                oldMaxLength: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "USUARIO",
                type: "character varying(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(11)",
                oldMaxLength: 11);
        }
    }
}
