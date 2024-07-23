using Repo_Dispatcher_Contracts;

namespace Dispatcher
{
    public class RepoProcessor
    {
        private readonly IRepositoryOperator _repositoryOperator;

        public RepoProcessor(IRepositoryOperator repositoryOperator) 
        {
            _repositoryOperator = repositoryOperator;
        }

        
    }
}
