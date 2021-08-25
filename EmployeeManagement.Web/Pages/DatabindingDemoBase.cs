﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class DatabindingDemoBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";

        protected string Gender { get; set; } = "Male";

        protected string Colour { get; set; } = "background-color:white";
    }
}