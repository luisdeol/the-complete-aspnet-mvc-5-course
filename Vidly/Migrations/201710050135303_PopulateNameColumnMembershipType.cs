namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameColumnMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NAME = 'Pay as you Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET NAME = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MembershipTypes SET NAME = 'Quaterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET NAME = 'Annual' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
