using Domain.StudentAggregate;

public interface IStudentService
{
    // Create a new student
    Student CreateStudent(string name, string email);

    // Get a student by ID
    Student GetStudentById(long id);

    // Update student information
    void UpdateStudent(Student student);

    // Delete a student by ID
    void DeleteStudent(long id);

    // Enroll a student in a course
    string EnrollStudent(long studentId, long courseId);

    // Get all courses a student is enrolled in

    // Get all students
    IEnumerable<Student> GetAllStudents();


}
