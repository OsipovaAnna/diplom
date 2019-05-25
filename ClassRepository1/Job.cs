using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Job : BaseModel
    {
        public string CustomerName { get; set; }
        public string TaskName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    }
}
