﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Customer : BaseModel
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string Status { get; set; }
    }
}