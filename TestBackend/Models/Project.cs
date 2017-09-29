using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBackend.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public State State { get; set; }

        public List<Task> Tasks { get; set; }
    }
}