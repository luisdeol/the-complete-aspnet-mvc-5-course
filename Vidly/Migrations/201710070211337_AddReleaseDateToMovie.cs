namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
