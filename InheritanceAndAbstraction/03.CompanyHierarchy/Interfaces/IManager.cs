﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
    interface IManager
    {
        IEnumerable<Employee> Employees { get; set; }
    }
}
