namespace CleanArchWPF.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; }
        public DateTime Deadline { get; set; }
        public int Progress { get; set; }
        public bool IsDone { get; set; }
        public int TaskStatus { get; set; }
    }
}
