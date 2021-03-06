﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.WebCore.ViewModels.JobFunction
{
    public class JobFunctionEditViewModel
    {
        public int JobFunctionId { get; set; }

        public int DepartmentId { get; set; }

        public int SectionId { get; set; }

        [Required]
        public string FunctionName { get; set; }

        public string FunctionCode { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
