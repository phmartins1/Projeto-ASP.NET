using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

#nullable disable

namespace Payroll.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO dbo.Funcionarios(Nome, Email, Senha)" + "VALUES('Pedro Manoel', 'manoel@gmail.com','147')");

            migrationBuilder.Sql("INSERT INTO dbo.Holerites(HoleriteName, DataHolerite, ImagemUrl, FuncionarioId)" + "VALUES('PedroJan', '01/2023','C:.Holerites.Jan', '1')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
