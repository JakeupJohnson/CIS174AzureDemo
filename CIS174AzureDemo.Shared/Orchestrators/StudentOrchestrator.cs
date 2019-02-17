using CIS174AzureDemo.Domain;
using CIS174AzureDemo.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174AzureDemo.Shared.Orchestrators
{
    public class StudentOrchestrator
    {
        private readonly SchoolContext _schoolContext;

        public StudentOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }

        public List<StudentViewModel> GetAllStudents()
        {
            var students = _schoolContext.Students.Select(x => new StudentViewModel
            {
                StudentName = x.StudentName,
                DateOfBirth = x.DateOfBirth,
                Height = x.Height,
                Weight = x.Weight
            }).ToList();

            return students;
        }
    }
}
