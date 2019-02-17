using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174AzureDemo.Domain.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        [StringLength(50)]
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}
