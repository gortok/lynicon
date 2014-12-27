﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lynicon.Models;

namespace Lynicon.Test.Models
{
    [Serializable]
    public class SingleContent : BaseContent
    {
        public GeneralSummary Summary { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }

        public SingleContent()
        {
            Summary = new GeneralSummary();
        }
    }
}