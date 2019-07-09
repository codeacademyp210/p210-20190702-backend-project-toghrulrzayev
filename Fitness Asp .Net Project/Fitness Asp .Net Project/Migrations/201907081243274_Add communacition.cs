namespace Fitness_Asp.Net_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcommunacition : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseSchedules", "DayId", c => c.Int(nullable: false));
            CreateIndex("dbo.CourseSchedules", "DayId");
            AddForeignKey("dbo.CourseSchedules", "DayId", "dbo.Days", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseSchedules", "DayId", "dbo.Days");
            DropIndex("dbo.CourseSchedules", new[] { "DayId" });
            DropColumn("dbo.CourseSchedules", "DayId");
        }
    }
}
