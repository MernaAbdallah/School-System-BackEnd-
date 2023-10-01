using Domain.SchoolAggregate;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.EnrollmentAggregate
{
    public class Enrollment
    {
        [Key] // Specify the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
        public long EnrollmentID { get; private set; }

        [ForeignKey("Student")]
        public long StudentID { get; private set; }

        [ForeignKey("Course")]
        public long CourseID { get; private set; }

        public Student Student { get; private set; }
        public Course Course { get; private set; }

        public Enrollment()
        {
        }

        public Enrollment(Course course)
        {
            Course = course;
        }
    }
}
