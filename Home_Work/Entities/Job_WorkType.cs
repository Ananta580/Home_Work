
namespace Home_Work.Models
{
    using System.Collections.Generic;

    public partial class Job_WorkType
    {
        public Job_WorkType()
        {
            this.Job_Post = new HashSet<Job_Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Job_Post> Job_Post { get; set; }
    }
}
