namespace BLL_Services
{
    public class TaskProcessor : ITaskProcessor
    {
        public bool CheckIsDone(int progress)
        {
            return progress == 100;
        }
    }
}
