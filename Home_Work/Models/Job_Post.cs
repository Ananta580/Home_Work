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
    
    public partial class Job_Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Requirement { get; set; }
        public string WorkingHour { get; set; }
        public int WorkingTypeId { get; set; }
        public int UserId { get; set; }
        public int SkillTypeId { get; set; }
    }
}
