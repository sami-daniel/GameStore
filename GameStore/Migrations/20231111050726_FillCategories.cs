using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Migrations
{
    /// <inheritdoc />
    public partial class FillCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categories (CategoryName, CategoryDescription)" +
                "values ('Console', 'Aparelho para executar jogos eletrônicos')");
            migrationBuilder.Sql("INSERT INTO categories (CategoryName, CategoryDescription) " +
                "VALUES ('Jogos', 'Jogos eletrônicos em ambas as mídias')");
            migrationBuilder.Sql("INSERT INTO categories (CategoryName, CategoryDescription) " +
                "VALUES ('Periféricos', 'Periféricos e acessórios para consoles etc.')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from categories");
        }
    }
}
