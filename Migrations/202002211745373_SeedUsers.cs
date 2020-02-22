namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'023247c7-6e32-41a8-bbcc-7f35ee8f9bea', N'admin@vidly.com', 0, N'ALwpleDPjboZNJpKpOfCd7Zy1O6dwjUeR7m7MsU74CYYSIW6U6+B0iAldzdlpolwZw==', N'7be59a9c-137d-4b4c-bdc5-8ad8958092f2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16892051-56e8-4a84-b937-68cc0d33472c', N'guest@vidly.com', 0, N'ANzbqCCAITbPKZNTEDBGkpjkntAonJUhSxZRvElrlucRJ+HwpdX2lE12IuR5CqlVNg==', N'd4da69c5-dd46-45b3-b928-aed4baccc23c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd5136a1f-2c58-4a5f-b5cd-06d76c079846', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'023247c7-6e32-41a8-bbcc-7f35ee8f9bea', N'd5136a1f-2c58-4a5f-b5cd-06d76c079846')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
