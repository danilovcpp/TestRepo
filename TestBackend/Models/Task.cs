using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBackend.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; set; }
        public State State { get; set; }
        
        public int Project_Id { get; set; }
    }
}