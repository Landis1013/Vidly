namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock,Genre_Id) VALUES ('Hangover',5,'3/7/2017','6/5/2009',10,5)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock,Genre_Id) VALUES ('Die Hard',1,'3/7/2017','7/15/1988',8,1)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock,Genre_Id) VALUES ('The Terminator',1,'3/7/2017','10/26/1984',6,1)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock,Genre_Id) VALUES ('Toy Story',3,'3/7/2017','11/22/1995',5,3)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock,Genre_Id) VALUES ('Titanic',4,'3/7/2017','12/19/1997',2,4)");

        }
        
        public override void Down()
        {
        }
    }
}
