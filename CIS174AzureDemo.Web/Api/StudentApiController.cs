using CIS174AzureDemo.Shared.Orchestrators;
using CIS174AzureDemo.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CIS174AzureDemo.Web.Api
{
    [Route("api/v1/students")]
    public class StudentApiController : ApiController
    {
        private readonly StudentOrchestrator _studentOrchestrator;

        public StudentApiController()
        {
            _studentOrchestrator = new StudentOrchestrator();
        }

        [HttpGet]
        public List<StudentViewModel> GetAllStudents()
        {
            var students = _studentOrchestrator.GetAllStudents();

            return students;
        }
    }
    
}
