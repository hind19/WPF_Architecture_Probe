using UI_Dispatcher_Contracts;

namespace Dispatcher
{
    public interface IUiOperator
    {
        IEnumerable<IUiDispatcherDto> GetTasksDAtaForUi();
    }
}
