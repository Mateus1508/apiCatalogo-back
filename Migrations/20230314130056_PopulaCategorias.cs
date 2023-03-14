using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categoria(Nome, ImageUrl) Values('Bebida', 'bebidas.jpg')");
            mb.Sql("Insert into Categoria(Nome, ImageUrl) Values('Lanches', 'lanches.jpg')");
            mb.Sql("Insert into Categoria(Nome, ImageUrl) Values('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
