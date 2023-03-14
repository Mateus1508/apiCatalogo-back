using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" + 
                "Values('Coca-Cola Diet','Refrigerante de Cola 350ml',5.45,'cocacola.jpg',50,now(),1)");

            mb.Sql("Insert into Produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" + 
                "Values('Sanduiche','Sanduiche de presunto',7.00,'sanduiche.jpg',20,now(),2)");
            
            mb.Sql("Insert into Produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" + 
                "Values('Picole','Picole da Falcao',2.00,'picole.jpg',100,now(),3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produto");
        }
    }
}
