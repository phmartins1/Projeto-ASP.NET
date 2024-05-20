using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payroll.Migrations
{
    /// <inheritdoc />
    public partial class PopularHolerites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO dbo.Holerites(HoleriteName, DataHolerite, ImagemUrl, FuncionarioId)" + "VALUES('Jan/2023', '01/2023','C:.Holerites.Jan', 1)");
            migrationBuilder.Sql("INSERT INTO dbo.Holerites(HoleriteName, DataHolerite, ImagemUrl, FuncionarioId)" + "VALUES('Fev/2023', '02/2023','C:\\Holerites\\Jan', 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
