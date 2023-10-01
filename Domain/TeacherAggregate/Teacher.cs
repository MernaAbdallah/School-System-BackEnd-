using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SchoolAggregate;
using Domain.SchoolAggregate.Input;
using Domain.TeacherAggregate.Input;
using Domain.Lookups;

namespace Domain.TeacherAggregate
{
    public class Teacher
    {



        [Key] // Specify the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
        public long TeacherID { get; private set; }

        public string Name { get; private set; }
        public string Email { get; private set; }


        public long? CategoryId { get; private set; }
        public TeacherCategory Category { get; private set; }

        public long? SchoolId { get; private set; }
        public School School { get; private set; }

        //public long? CourseId { get; private set; }
        //public Course Course { get; private set; }
        public ICollection<Course> Course { get; private set; } = new List<Course>();



        public void AddNewTeacher(TeacherInput input)
        {
            this.Name = input.Name;
            this.Email = input.Email;


            //this.Category = input.Category;
            //this.School = input.School;
            //this.SchoolId = input.SchoolId;

        }
    }
}
