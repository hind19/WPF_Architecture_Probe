using Repo_Dispatcher_Contracts;

namespace DB_Repo
{
    public class RepositoryOperator : IRepositoryOperator
    {
        public IEnumerable<IRepoDispatcherDto> GetTasksList()
        {
            return new List<IRepoDispatcherDto>()
            {
                new RepoDispatcherDto
                {
                     Deadline = new DateTime(2024,10,8),
                     Progress = 10,
                     TaskName = "Future started task",
                     TaskStatus = 1
                },
                new RepoDispatcherDto
                {
                     Deadline = new DateTime(2024,7,20),
                     Progress = 100,
                     TaskName = "Completed task",
                     TaskStatus = 4
                },
                  new RepoDispatcherDto
                {
                     Deadline = new DateTime(2024,8,10),
                     Progress = 0,
                     TaskName = "Not started task",
                     TaskStatus = 0
                },
                    new RepoDispatcherDto
                {
                     Deadline = new DateTime(2024,7,20),
                     Progress = 11,
                     TaskName = "Delayed task",
                     TaskStatus = 2
                },
                      new RepoDispatcherDto
                {
                     Deadline = new DateTime(2024,7,20),
                     Progress = 100,
                     TaskName = "Cancelled task",
                     TaskStatus = 3
                },
            }.AsEnumerable();
        }
    }
}
