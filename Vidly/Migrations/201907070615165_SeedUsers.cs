namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'06896c3e-ad58-4d66-924e-a18886724ca8', N'admin@vidly.com', 0, N'ALrK+GIaFSaff8pBMHDc6Ayw8JeR+J6wUzHVL7ahmv0sUCjyVuJtBIxklLHFn6kAbw==', N'd9c394a9-7ec4-4e71-8832-4910137c375e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2bde3d79-635e-447f-ad14-d37c64fb5441', N'sumansjs@gmail.com', 0, N'AAYx1DRIl4EuZMJZ1Z9m7K1UQibOoWVRaLOtVqWc1ABiTiW9yaMKPx6gvEboYhXNlg==', N'f6427b50-0ec4-438d-ae99-526ce39a596e', NULL, 0, 0, NULL, 1, 0, N'sumansjs@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c9d6570f-ca7f-47ad-90c6-e317b2f6fff4', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'06896c3e-ad58-4d66-924e-a18886724ca8', N'c9d6570f-ca7f-47ad-90c6-e317b2f6fff4')
");
        }
        
        public override void Down()
        {
        }
    }
}
