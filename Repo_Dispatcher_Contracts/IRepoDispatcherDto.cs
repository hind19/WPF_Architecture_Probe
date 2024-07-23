namespace Repo_Dispatcher_Contracts
{
    public interface IRepoDispatcherDto
    {
        public string TaskName { get; set; }
        public DateTime Deadline { get;  set; }
        public int Progress { get;  set; }
        public int TaskStatus { get; set; }
    }
}
