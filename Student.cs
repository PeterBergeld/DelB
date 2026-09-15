
// hmm  20:31

using System.Security.Cryptography.X509Certificates;

class Student
{
    public string Name {get; set;}
    public List<Course> Courses{ get; set;} = new List<Course>();



   public void Join(Course course)          // If a student wants to join a course its from the enroll (this) and .Add to course
{
    if (course.Enroll(this))
    {
        Courses.Add(course);
    }
}
    public void Leave(Course course)
    {
        if (Courses.Contains(course))
        {
            
        }
    }
}


