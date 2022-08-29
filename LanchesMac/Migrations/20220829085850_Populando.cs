using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class Populando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(categorianome, descricao)" +
            "VALUES('Assados', 'Apenas lanches assados')");

            migrationBuilder.Sql("INSERT INTO Categorias(categorianome, descricao)" +
            "VALUES('Fritos', 'Apenas lanches Fritos')");

            migrationBuilder.Sql("INSERT INTO Categorias(categorianome, descricao)" +
            "VALUES('Naturais', 'Apenas lanches Naturais')");

            migrationBuilder.Sql("INSERT INTO Categorias(categorianome, descricao)" +
           "VALUES('Mais Pedidos', 'Os lanches mais desejados pelos nossos clientes')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
