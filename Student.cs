
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
    public void Leave(Course course)  // course in Course leaves . read Right --->Left 
    {
        if (Courses.Contains(course))
        {
            Courses.Remove(course);
            course.Remove(this);
        }
public override string ToString() // Should return the name
    {
        return Name;
    }
    public void Schedule()
    {
        foreach (Course course in Courses)
        {
            System.Console.WriteLine(course); // Här kallar vi på course som är ett Course-Objekt (Tostring i Courses)
        }
    }
    }
}


//Student class done


