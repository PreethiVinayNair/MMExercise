 using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ToyRobotSimulatorAPI.ModelBinding
{
    public class QueryArgumentsModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var query = bindingContext.ActionContext.HttpContext.Request.Query;
            var model = new QueryArguments(query);
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
