namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomers : DbMigration
    {
        public override void Up()
        {
            //CAST('1985-01-11' AS DateTime)
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (1, 0, 0, 0,'Pay as you go')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (2, 30, 1, 10,'Monthly')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (3, 90, 3, 15,'Quarter')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (4, 300, 12, 20,'Yearly')");

            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsletter,MembershipTypeId,Birthdate) VALUES ('Oliver Twist', 'true', 1, CAST('1985-06-18' AS DateTime))");
            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsletter,MembershipTypeId,Birthdate) VALUES ('Harry Todd', 'false', 2, CAST('1995-11-18' AS DateTime))");
            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsletter,MembershipTypeId,Birthdate) VALUES ('Jenifer Seline', 'true', 3, CAST('1987-08-15' AS DateTime))");
            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsletter,MembershipTypeId,Birthdate) VALUES ('Mins Minsley', 'false', 4, CAST('1999-01-19' AS DateTime))");
        }

        public override void Down()
        {
        }
    }
}
