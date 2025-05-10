﻿namespace Job.Models
{
    public class NotificationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsRead { get; set; }
        

    }
}
