
namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job_Post
    {
        public Job_Post()
        {
            this.Job_HomeBase = new HashSet<Job_HomeBase>();
            this.Profile_WorkStatus = new HashSet<Profile_WorkStatus>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Requirement { get; set; }
        public string WorkingHour { get; set; }
        public int WorkingTypeId { get; set; }
        public int UserId { get; set; }
        public int SkillTypeId { get; set; }
    
        public virtual ICollection<Job_HomeBase> Job_HomeBase { get; set; }
        public virtual Job_SkillType Job_SkillType { get; set; }
        public virtual Job_WorkType Job_WorkType { get; set; }
        public virtual Profile_User Profile_User { get; set; }
        public virtual ICollection<Profile_WorkStatus> Profile_WorkStatus { get; set; }
    }
}
