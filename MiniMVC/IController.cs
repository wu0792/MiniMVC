using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public interface IController
    {
        void Execute(RequestContext requestContext);
    }
}