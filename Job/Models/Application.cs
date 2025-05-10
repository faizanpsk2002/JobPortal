namespace Job.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int UserId { get; set; }
        public string ResumeUrl { get; set; }
        public DateTime AppliedOn { get; set; }

        public JobModel Job { get; set; }
        public User User { get; set; }
    }
}
