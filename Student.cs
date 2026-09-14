
// hmm  20:31

class Student
{
    public string Name {get; set;}
    public List<Course> Courses{ get; set;} = new List<Course>();

}

    public void Join(Course course)
{
    course.Enroll(this); // This means that this actually object(Student) is what is executing Join() 
    
}


