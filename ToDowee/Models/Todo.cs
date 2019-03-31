﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDowee.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }
        public int Priority { get; set; }
        public string Attachments { get; set; }
    }
}