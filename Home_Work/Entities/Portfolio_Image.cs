
namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Portfolio_Image
    {
        public int ID { get; set; }
        public string ImageCaption { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Photo { get; set; }
        public Nullable<int> PortfolioID { get; set; }
    
        public virtual Profile_User Profile_User { get; set; }
        public virtual Profile_Portfolio Profile_Portfolio { get; set; }
    }
}
