
namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Profile_Portfolio
    {
        public Profile_Portfolio()
        {
            this.Portfolio_Image = new HashSet<Portfolio_Image>();
        }

        public int ID { get; set; }
        public string Project_Name { get; set; }
        public DateTime? Date { get; set; }
        public string ProjectDescription { get; set; }
        public string ToolsUsed { get; set; }
        public int? UserID { get; set; }

        public virtual ICollection<Portfolio_Image> Portfolio_Image { get; set; }
        public virtual Profile_User Profile_User { get; set; }
    }
}
