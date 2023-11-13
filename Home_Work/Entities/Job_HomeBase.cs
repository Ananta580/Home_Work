
namespace Home_Work.Models
{
    using System;

    public partial class Job_HomeBase
    {
        public int ID { get; set; }
        public int? PostId { get; set; }
        public string JobLocation { get; set; }
        public decimal? ContactNo { get; set; }
        public decimal? CountryCode { get; set; }
        public DateTime? Date { get; set; }

        public virtual Job_Post Job_Post { get; set; }
    }
}
