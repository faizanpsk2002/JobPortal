namespace Job.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public DateTime PostedDate { get; set; }
        public int EmployerId { get; set; }

        public User Employer { get; set; }
    }
}
