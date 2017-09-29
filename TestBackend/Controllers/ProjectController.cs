using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestBackend.Models;

namespace TestBackend.Controllers
{
    public class ProjectController : ApiController
    {
        private static List<Project> _projects = new List<Project>() {
            new Project() {
                Id = 1,
                Name = "Project 1",
                Description = "Description of Project 1",
                State = State.Active,
            },
            new Project() {
                Id = 2,
                Name = "Project 2",
                Description = "Description of Project 2",
                State = State.Active,
            },
        };

        // GET api/project
        public IEnumerable<Project> Get()
        {
            return _projects;
        }

        // GET api/project/2
        public Project Get(int id)
        {
            return _projects.Find(p => p.Id == id);
        }

        // POST api/project
        public void Post([FromBody]Project project)
        {
            _projects.Add(project);
        }

        // PUT api/project/2
        public void Put(int id, [FromBody]Project project)
        {
            var entry = _projects.Find(p => p.Id == id);

            entry.Name = project.Name;
            entry.Description = project.Description;
            entry.State = project.State;
        }

        // DELETE api/project/2
        public void Delete(int id)
        {
            _projects.RemoveAll(p => p.Id == id);
        }
    }
}