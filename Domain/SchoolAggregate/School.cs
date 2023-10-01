using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.ManagerAggregate;
using Domain.TeacherAggregate;
using Domain.SchoolAggregate.Input;

namespace Domain.SchoolAggregate
{
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SchoolID { get; private set; }
        public string Name { get; private set; }

        public long? MangerId { get; private set; }
        public virtual Manger Manger { get; private set; }

        public ICollection<Teacher> Teachers { get; private set; } = new List<Teacher>();
        public ICollection<Student> Students { get; private set; } = new List<Student>();

        public void AddNewSchole(SchoolInput input)
        {
            this.Name = input.Name;
            foreach (var item in input.studentInputs)
            {
                Students.Add(new Student(item));
            }

        }


        //public ICollection<Course> Courses { get; private set; } = new List<Course>();
    }
}
