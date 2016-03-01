using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public class RawContentResult : ActionResult
    {
        public RawContentResult(string rawData)
        {
            this.RawData = rawData;
        }

        public string RawData { get; private set; }

        public override void ExecuteResult(ControllerContext context)
        {
            context.RequestContext.HttpContext.Response.Write(this.RawData);
        }
    }
}