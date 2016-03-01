using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MiniMVC
{
    public class ControllerActionInvoker : IActionInvoker
    {
        public IModelBinder ModelBinder { get; private set; }

        public ControllerActionInvoker()
        {
            this.ModelBinder = new DefaultModelBinder();
        }

        public void InvokeAcion(ControllerContext controllerContext, string actionName)
        {
            MethodInfo method = controllerContext.Controller.GetType().GetMethods().First(t => string.Compare(actionName, t.Name, true) == 0);
            List<object> parameters = new List<object>();
            foreach (ParameterInfo parameter in method.GetParameters())
            {
                parameters.Add(this.ModelBinder.BindModel(controllerContext, parameter.Name, parameter.ParameterType));
            }

            ActionResult actionResult = method.Invoke(controllerContext.Controller, parameters.ToArray()) as ActionResult;
            actionResult.ExecuteResult(controllerContext);
        }
    }
}