class Course
{
    
    public string Name { get; set; } // Name of the member 
    public int MaxSeats { get; set; } // Maximum number of seats available in the course
    
    public List<Student> Students { get; set; } = new List<Student>(); // List of students enrolled in the course

    public void Enroll (Student student)
    {
        if (Students.Count< MaxSeats) // Checks if there are any seats for potentiall students
        Students.Add(student);
        Students.Contains(student); // Checks the student aint in the list

        if (Students.Count < MaxSeats && !Students.Contains(student)) // If students count is less than the maxseats = det finns plats
        // && if the student doesnt exist.
        {
            Students.Add(student);
        }
        else if (Students.Contains(student))
        {
            
                System.Console.WriteLine("Studenten är readn anmäld"); // If the student is already enrolled
        }
        else  // If the student is already enrolled he gets the message
        {
            
             Console.WriteLine("Kursen är full"); // If the course is already full 
        }
}