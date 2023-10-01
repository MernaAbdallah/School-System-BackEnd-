using Domain.EnrollmentAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Lookups;
using Domain.SchoolAggregate.Input;

namespace Domain.SchoolAggregate
{
    public class Student
    {
        public Student()
        {

        }
        public Student(StudentInput item)
        {
            this.Name = item.Name;
            this.Email = item.Email;
        }

        [Key] // Specify the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
        public long StudentID { get; private set; }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public long SchoolID { get; private set; }
        public virtual School School { get; private set; }

        public long? StudentLevelId { get; private set; }
        public virtual StudentLevel StudentLevel { get; private set; }
        public ICollection<Enrollment> Enrolls { get; private set; } = new List<Enrollment>();


    }

}
