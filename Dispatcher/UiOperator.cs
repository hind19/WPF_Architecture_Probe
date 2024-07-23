using AutoMapper;
using BLL_Services;
using Dispatcher.Models;
using Repo_Dispatcher_Contracts;
using UI_Dispatcher_Contracts;

namespace Dispatcher
{
    public class UiOperator : IUiOperator
    {
        private readonly ITaskProcessor _taskProcessor;
        private readonly IRepositoryOperator _repositoryOperator;
        private readonly IMapper _mapper;

        public UiOperator(ITaskProcessor taskProcessor, IRepositoryOperator repositoryOperator, IMapper mapper)
        {
            _taskProcessor = taskProcessor;
            _repositoryOperator = repositoryOperator;
            _mapper = mapper;
        }

        public IEnumerable<IUiDispatcherDto> GetTasksDAtaForUi()
        {
            var tasks = _mapper.Map<IEnumerable<UiDispatcherDto>>(_repositoryOperator.GetTasksList());
            foreach (var task in tasks)
            {
               task.IsDone = _taskProcessor.CheckIsDone(task.Progress);
            }

            return tasks;
        }
    }
}
