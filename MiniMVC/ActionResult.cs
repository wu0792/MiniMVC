﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public abstract class ActionResult
    {
        public abstract void ExecuteResult(ControllerContext context);
    }
}