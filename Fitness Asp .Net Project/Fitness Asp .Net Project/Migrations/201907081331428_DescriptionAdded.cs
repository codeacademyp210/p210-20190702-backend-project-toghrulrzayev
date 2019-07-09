namespace Fitness_Asp.Net_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescriptionAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseSchedules", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseSchedules", "Description");
        }
    }
}
