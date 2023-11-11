using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Migrations
{
    /// <inheritdoc />
    public partial class FillProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO products (productname, productshortdescription, productdetaileddescription, producturlimage, producturlthumbnailimage, isproductpreferred, instock, productprice, categoryid) " +
                            "VALUES ('Jogo 1', 'Descrição curta do Jogo 1', 'Descrição detalhada do Jogo 1', 'URL da Imagem do Jogo 1', 'URL da Miniatura do Jogo 1', 1, 1, 75.00, 2)");

            migrationBuilder.Sql("INSERT INTO products (productname, productshortdescription, productdetaileddescription, producturlimage, producturlthumbnailimage, isproductpreferred, instock, productprice, categoryid) " +
                "VALUES ('Console 1', 'Descrição curta do Console 1', 'Descrição detalhada do Console 1', 'URL da Imagem do Console 1', 'URL da Miniatura do Console 1', 1, 1, 250.00, 1)");

            migrationBuilder.Sql("INSERT INTO products (productname, productshortdescription, productdetaileddescription, producturlimage, producturlthumbnailimage, isproductpreferred, instock, productprice, categoryid) " +
                "VALUES ('Fone de Ouvido Gamer', 'Descrição curta do Fone de Ouvido Gamer', 'Descrição detalhada do Fone de Ouvido Gamer', 'URL da Imagem do Fone de Ouvido Gamer', 'URL da Miniatura do Fone de Ouvido Gamer', 1, 1, 99.99, 3)");

            migrationBuilder.Sql("INSERT INTO products (productname, productshortdescription, productdetaileddescription, producturlimage, producturlthumbnailimage, isproductpreferred, instock, productprice, categoryid) " +
                "VALUES ('Jogo 2', 'Descrição curta do Jogo 2', 'Descrição detalhada do Jogo 2', 'URL da Imagem do Jogo 2', 'URL da Miniatura do Jogo 2', 1, 1, 49.99, 2)");

            migrationBuilder.Sql("INSERT INTO products (productname, productshortdescription, productdetaileddescription, producturlimage, producturlthumbnailimage, isproductpreferred, instock, productprice, categoryid) " +
                "VALUES ('Teclado Gamer', 'Descrição curta do Teclado Gamer', 'Descrição detalhada do Teclado Gamer', 'URL da Imagem do Teclado Gamer', 'URL da Miniatura do Teclado Gamer', 1, 1, 129.50, 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from products");
        }
    }
}
