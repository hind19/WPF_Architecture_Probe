using Repo_Dispatcher_Contracts;

namespace DB_Repo.Models
{
    public class RepoDispatcherDto : IRepoDispatcherDto
    {
        public string TaskName { get; set; }
        public DateTime Deadline { get; set; }
        public int Progress { get; set; }
        public int TaskStatus { get; set; }
    }
}
