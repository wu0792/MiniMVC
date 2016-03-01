using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public interface IActionInvoker
    {
        void InvokeAcion(ControllerContext controllerContext, string actionName);
    }
}