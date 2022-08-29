namespace BasicDI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassRoomAndStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        ClassRoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ClassRoomId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        ClassRoomId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoomId)
                .Index(t => t.ClassRoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.Students", new[] { "ClassRoomId" });
            DropTable("dbo.Students");
            DropTable("dbo.ClassRooms");
        }
    }
}
