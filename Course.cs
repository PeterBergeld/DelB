class Course
{
    
    public string Name { get; set; } // Name of the member 
    public int MaxSeats { get; set; } // Maximum number of seats available in the course
    
    public List<Student> Students { get; set; } = new List<Student>(); // List of students enrolled in the course

}