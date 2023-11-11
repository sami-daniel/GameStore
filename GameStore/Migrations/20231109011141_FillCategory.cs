using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Migrations
{
    /// <inheritdoc />
    public partial class FillCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categories (CategoryName, CategoryDescription)" +
                " values ('Console', 'Aparelho para executar jogos eletrônicos')");
            migrationBuilder.Sql("insert into categories (CategoryName, CategoryDescription)" +
                " values ('Jogo', 'Jogo eletrônico')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from categories");
        }
    }
}
