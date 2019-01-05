namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'439e9348-fbc3-4388-bf3d-2e252dfc3b6a', N'guest@vidly.com', 0, N'ADJeWuDTMXQDplasB7mVT71apI9Y0dmaYHKpS83YfrP13CEBSTGe5bfq8kjpcVFnfQ==', N'180849e2-84c6-4eda-b96d-9cdacbc4f9a3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd86ba65-1d04-4317-9c1b-08be6e49d873', N'admin@vidly.com', 0, N'AJdAdezqlTS7xWSnj1UP7rr5vT7pvgkXBhVHzhApen1M2MsuKXKLG9luJcQflMeOTA==', N'666455a3-4f93-4f76-941d-4c895d313efc', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'42a39c0f-8ae5-401d-985b-294b80f20dae', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd86ba65-1d04-4317-9c1b-08be6e49d873', N'42a39c0f-8ae5-401d-985b-294b80f20dae')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
