using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dip.Models
{
    public class JobsModel
    {
        public List<Job> Jobs { get; set; }
        public Job NewJob { get; set; }
        /*public string CustomerName { get; set; }
        public string TaskName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }*/
    }
}