﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public class ControllerContext
    {
        public ControllerBase Controller { get; set; }
        public RequestContext RequestContext { get; set; }
    }
}