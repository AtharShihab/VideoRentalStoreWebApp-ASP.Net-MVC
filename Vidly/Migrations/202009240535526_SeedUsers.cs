namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'90f459f4-aed8-4269-90df-cb7196780e40', N'admin@vidly.com', 0, N'AKOuwEApbzvk1Yo2+znCw8rPD9SFdbdrA+WzfD8S3KgbySDATuHeJCj7xRG39v5fHw==', N'aa2c1ad0-0fdb-4763-8db6-7ac9009b9eef', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe4e8b46-c733-4c5e-93f9-b1953f6e24f5', N'guest@vidly.com', 0, N'AFgR3llQ/7VVT+Opinod5yKO8EPmnAPBdwkk5Lx5skU6upwcFNdsxMWlhowI0XQXXw==', N'878fd5f6-b7a4-4d11-a027-d9bfaf8a074d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'da15a547-97fc-4119-b1ee-dd111a5e7b0d', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90f459f4-aed8-4269-90df-cb7196780e40', N'da15a547-97fc-4119-b1ee-dd111a5e7b0d')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
