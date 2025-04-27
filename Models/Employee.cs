using System;
using System.Collections.Generic;

namespace EMSD.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? Name { get; set; }

    public string? Cnic { get; set; }

    public string? Phone { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public int? DeptId { get; set; }

    public int? ShiftId { get; set; }

    public virtual Department? Dept { get; set; }

    public virtual Shift? Shift { get; set; }
}
