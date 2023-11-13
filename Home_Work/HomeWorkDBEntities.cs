namespace Home_Work.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class HomeWorkDBEntities : DbContext
    {
        public HomeWorkDBEntities()
            : base("name=HomeWorkDBEntities")
        {
        }

        public  DbSet<Contact_Message> Contact_Message { get; set; }
        public  DbSet<Contact_Messanger> Contact_Messanger { get; set; }
        public  DbSet<Job_HomeBase> Job_HomeBase { get; set; }
        public  DbSet<Job_Post> Job_Post { get; set; }
        public  DbSet<Job_SkillType> Job_SkillType { get; set; }
        public  DbSet<Job_WorkType> Job_WorkType { get; set; }
        public  DbSet<Portfolio_Image> Portfolio_Image { get; set; }
        public  DbSet<Profile_Education> Profile_Education { get; set; }
        public  DbSet<Profile_Portfolio> Profile_Portfolio { get; set; }
        public  DbSet<Profile_Training> Profile_Training { get; set; }
        public  DbSet<Profile_User> Profile_User { get; set; }
        public  DbSet<Profile_Work> Profile_Work { get; set; }
        public  DbSet<Profile_WorkStatus> Profile_WorkStatus { get; set; }
    }
}
