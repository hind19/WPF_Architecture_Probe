namespace Repo_Dispatcher_Contracts
{
    public interface IRepositoryOperator
    {
        IEnumerable<IRepoDispatcherDto> GetTasksList();
    }
}
