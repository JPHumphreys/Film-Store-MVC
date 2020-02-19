namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES('The Terminator' , 1, CAST('1985-01-11' AS DateTime), CAST('2020-02-19' AS DateTime), 6)");
            Sql("INSERT INTO Movies VALUES('The Taking of Pelham 123' , 2, CAST('2009-05-04' AS DateTime), CAST('2020-02-19' AS DateTime), 3)");
            Sql("INSERT INTO Movies VALUES('Bee Movie' , 3, CAST('2007-12-14' AS DateTime), CAST('2020-02-19' AS DateTime), 12)");
            Sql("INSERT INTO Movies VALUES('About Time' , 4, CAST('2013-08-08' AS DateTime), CAST('2020-02-19' AS DateTime), 2)");
            Sql("INSERT INTO Movies VALUES('Jojo Rabbit' , 5, CAST('2020-01-03' AS DateTime), CAST('2020-02-19' AS DateTime), 9)");
        }
        
        public override void Down()
        {
        }
    }
}
