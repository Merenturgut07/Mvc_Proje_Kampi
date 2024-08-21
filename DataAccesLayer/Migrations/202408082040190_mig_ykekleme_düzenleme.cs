namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_ykekleme_düzenleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.YetenekKartım", "YKYetenekBaslik1", c => c.String(maxLength: 25));
            AddColumn("dbo.YetenekKartım", "YKYetenekBaslik2", c => c.String(maxLength: 25));
            AddColumn("dbo.YetenekKartım", "YKYetenekBaslik3", c => c.String(maxLength: 25));
            AlterColumn("dbo.YetenekKartım", "YKDescription", c => c.String(maxLength: 500));
            DropColumn("dbo.YetenekKartım", "YKYetenekBaslik");
        }
        
        public override void Down()
        {
            AddColumn("dbo.YetenekKartım", "YKYetenekBaslik", c => c.String(maxLength: 15));
            AlterColumn("dbo.YetenekKartım", "YKDescription", c => c.String(maxLength: 100));
            DropColumn("dbo.YetenekKartım", "YKYetenekBaslik3");
            DropColumn("dbo.YetenekKartım", "YKYetenekBaslik2");
            DropColumn("dbo.YetenekKartım", "YKYetenekBaslik1");
        }
    }
}
