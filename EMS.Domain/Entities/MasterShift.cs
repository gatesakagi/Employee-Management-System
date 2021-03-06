﻿using System;
using System.Collections.Generic;

namespace EMS.Domain.Entities
{
    public partial class MasterShift : BaseEntity
    {
        public MasterShift()
        {
            EmployeeState = new HashSet<EmployeeState>();
        }

        public byte ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public ICollection<EmployeeState> EmployeeState { get; set; }
    }
}
