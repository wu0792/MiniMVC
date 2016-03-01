using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public abstract class ControllerBase : IController
    {
        protected IActionInvoker AcionInvoker { get; set; }

        public ControllerBase()
        {
            this.AcionInvoker = new ControllerActionInvoker();
        }

        public void Execute(RequestContext requestContext)
        {
            ControllerContext context = new ControllerContext()
            {
                RequestContext = requestContext,
                Controller = this
            };

            string actionName = requestContext.RouteData.ActionName;
            this.AcionInvoker.InvokeAcion(context, actionName);
        }
    }
}