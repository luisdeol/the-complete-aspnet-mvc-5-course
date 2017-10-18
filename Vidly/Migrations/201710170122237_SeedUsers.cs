namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7ac7d31-46a7-4726-8c1c-a2eadf80894e', N'guest@vidly.com', 0, N'AM6zUyUAaDdZK4b8JVRCmGbdF8TeEZXNk2qNAbvJmHHN8PmDKB8f6MExo6up7mbniA==', N'b5fcec7a-9964-431c-923a-9d51620d94d3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd98bb998-5889-4f6b-83da-7b3cc3da6d7c', N'admin@vidly.com', 0, N'AMXyNa0rDv4+oXznMBSvEqdZbYqzMwnyxBBPKPTObystoCEjifsJwa87VTcP5eiprw==', N'ba33a4cd-e916-46f5-a3db-2d13af6a8b03', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'812772ed-8a6e-4c75-bad8-b0ec2aec69e2', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd98bb998-5889-4f6b-83da-7b3cc3da6d7c', N'812772ed-8a6e-4c75-bad8-b0ec2aec69e2')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
