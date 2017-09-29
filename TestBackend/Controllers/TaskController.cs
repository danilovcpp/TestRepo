using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestBackend.Models;

namespace TestBackend.Controllers
{
    public class TaskController : ApiController
    {
        private static List<Task> _tasks = new List<Task>() {
            new Task() {
                Id = 1,
                Name = "Task 1",
                Description = "Description of task 1",
                State = State.Active,
            },
            new Task() {
                Id = 2,
                Name = "Task 2",
                Description = "Description of task 2",
                State = State.Active,
            },
        };

        // GET api/task
        public IEnumerable<Task> Get()
        {
            return _tasks;
        }

        // GET api/task/2
        public Task Get(int id)
        {
            return _tasks.Find(t => t.Id == id);
        }

        // POST api/task
        public void Post([FromBody]Task task)
        {
            _tasks.Add(task);
        }

        // PUT api/task/2
        public void Put(int id, [FromBody]Task task)
        {
            var entry = _tasks.Find(t => t.Id == id);

            entry.Name = task.Name;
            entry.Description = task.Description;
            entry.EndDate = task.EndDate;
            entry.State = task.State;
            entry.Project_Id = task.Project_Id;
        }

        // DELETE api/task/2
        public void Delete(int id)
        {
            _tasks.RemoveAll(t => t.Id == id);
        }
    }
}
