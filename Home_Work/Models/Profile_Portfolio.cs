//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile_Portfolio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile_Portfolio()
        {
            this.Portfolio_Image = new HashSet<Portfolio_Image>();
        }
    
        public int ID { get; set; }
        public string Project_Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string ProjectDescription { get; set; }
        public string ToolsUsed { get; set; }
        public Nullable<int> UserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Portfolio_Image> Portfolio_Image { get; set; }
        public virtual Profile_User Profile_User { get; set; }
    }
}
