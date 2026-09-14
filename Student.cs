
// hmm  20:31

using System.Security.Cryptography.X509Certificates;

class Student
{
    public string Name {get; set;}
    public List<Course> Courses{ get; set;} = new List<Course>();



    public void Join(Course course)
{
    course.Enroll(this); // This means that this actually object(Student) is what is executing Join() 
    //Courses.Add(Course course) // False, Course is the class and course is the object, therefore

        if (!Courses.Contains(course))      // En true/false läggs till
        {
        Courses.Add(course);
        }

    
}
}