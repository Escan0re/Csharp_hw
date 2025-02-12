public class School
{
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<Course> Courses { get; set; }
    public List<Classroom> Classrooms { get; set; }
    public List<Staff> StaffMembers { get; set; }
    public List<Department> Departments { get; set; }
    public List<Event> SchoolEvents { get; set; }
}

public class Student
{
    public List<Course> EnrolledCourses { get; set; }
    public List<Grade> Grades { get; set; }
    public List<Attendance> AttendanceRecords { get; set; }
    public List<Parent> Parents { get; set; }
    public List<Assignment> Assignments { get; set; }
}

public class Teacher
{
    public List<Course> CoursesTaught { get; set; }
    public List<Qualification> Qualifications { get; set; }
}

public class Course
{
    public List<Student> EnrolledStudents { get; set; }
    public List<Assignment> Assignments { get; set; }
    public List<Schedule> ClassSchedules { get; set; }
    public List<Resource> CourseResources { get; set; }
    public List<Grade> Grades { get; set; }
}

public class Classroom
{
    public List<Course> CoursesHeld { get; set; }
    public List<Equipment> Equipment { get; set; }
    public List<Schedule> RoomSchedule { get; set; }
}

public class Staff
{
    public List<Schedule> WorkSchedule { get; set; }
}

public class Parent
{
    public List<Student> Children { get; set; }
    public List<Meeting> ParentTeacherMeetings { get; set; }
}

public class Department
{
    public List<Teacher> Teachers { get; set; }
    public List<Course> Courses { get; set; }
    public List<Equipment> DepartmentEquipment { get; set; }
}

public class Event
{
    public List<Person> Attendees { get; set; }
}

public class Assignment
{
    public List<Grade> Grades { get; set; }
    public List<Resource> AssignmentResources { get; set; }
}
