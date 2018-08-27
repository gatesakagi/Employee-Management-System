﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ApplicationCore.Models
{
    public class JobFunctionModel
    {
        public int JobFunctionId { get; set; }
        public int JobTitleId { get; set; }
        public string FunctionName { get; set; }
        public string FunctionDescription { get; set; }
        public JobTitleModel JobTitle { get; set; }
    }
}
