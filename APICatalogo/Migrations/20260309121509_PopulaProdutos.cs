using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(ProdutoId,Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" + 
                "Values('1','Coca-Cola Diet','Refrigerante de Cola 350ml',5.45,'cocacola.jpg',50,now(),1)");

            mb.Sql("Insert into Produtos(ProdutoId,Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +  
                "Values('2','Lanche de doritos','Lanche de doritos com cheddar',9.50,'doritos.jpg',10,now(),2)");

            mb.Sql("Insert into Produtos(ProdutoID,Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" + 
                "Values('3','Ouro branco','Ouro Branco bombom',3.30,'ourobranco.jpg',20,now(),3)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
