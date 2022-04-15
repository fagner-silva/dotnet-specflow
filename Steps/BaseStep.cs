using FrontEnd.Steps.Context;
namespace FrontEnd.Steps
{
    public class BaseStep
    {
        public BaseContext baseContext;
        public BaseStep(BaseContext baseContext)
        {
            this.baseContext = baseContext;
        }
    }
}