﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { set; get; }

        public DateTime EndDate { set; get; }

        [ForeignKey("LeaveTypeId")]

        public LeaveType LeaveType { get; set; }
        
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public string? RequestComments { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; }
    }
}
