namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_tema_anasayfa1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TemaAnaSayfas", "TemaAnaSayfaIsim", c => c.String(maxLength: 50));
            AlterColumn("dbo.TemaAnaSayfas", "TemaAnaSayfaAltBaslik", c => c.String(maxLength: 50));
            AlterColumn("dbo.TemaAnaSayfas", "TemaAnaSayfaBaslik", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TemaAnaSayfas", "TemaAnaSayfaBaslik", c => c.String(maxLength: 25));
            AlterColumn("dbo.TemaAnaSayfas", "TemaAnaSayfaAltBaslik", c => c.String(maxLength: 25));
            AlterColumn("dbo.TemaAnaSayfas", "TemaAnaSayfaIsim", c => c.String(maxLength: 25));
        }
    }
}
