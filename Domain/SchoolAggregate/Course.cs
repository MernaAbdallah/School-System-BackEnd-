using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EnrollmentAggregate;
using Domain.TeacherAggregate;
using Domain.SchoolAggregate.Input;

namespace Domain.SchoolAggregate
{
    public class Course
    {
        [Key] // Specify the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
        public long CourseID { get; private set; }
        public string Name { get; private set; }
        public long? TeacherId { get; private set; }
        public virtual Teacher Teacher { get; private set; }

        public ICollection<Enrollment> Enrolled { get; private set; } = new List<Enrollment>();


        public void AddNewSchole(CourseInput input)
        {
            this.Name = input.Name;


        }
    }
}
