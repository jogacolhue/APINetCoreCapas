using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusic.Data.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("insert into artists (name) values ('Iron Maiden')");

            migrationBuilder
                .Sql("insert into artists (name) values ('Tongo')");

            migrationBuilder
                .Sql("insert into musics(name, artistid) values ('La pituca', (select id from artists where name = 'Tongo'))");

            migrationBuilder
               .Sql("insert into musics(name, artistid) values ('Bolero Rockolero', (select id from artists where name = 'Tongo'))");

            migrationBuilder
                .Sql("insert into musics(name, artistid) values ('Dunoo', (select id from artists where name = 'Iron Maiden'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Musics");

            migrationBuilder
                .Sql("DELETE FROM Artists");
        }
    }
}