using System;
using System.Collections.Generic;

namespace EMSD.Models;

public partial class Shift
{
    public int ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public string? ShiftType { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
