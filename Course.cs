using System.Security.Cryptography.X509Certificates;
// Really need to go over this code again 16:26 09-14-26
// Alot of error-handling and some reading and more understanding of the code needed.
// Understand the fundamentals and what it does, but need to place the 
//exercise and code beside eachother
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

        public void Remove(Student student) // Secures so it wont crash if the student doenst exist
    {
        if (Students.Contains(student)) 
        {
            Students.Remove(student);
        }
        public void RollCall() // We need to write all the members in the list
        {
            foreach (Student student in Students) 
        {
            System.Console.WriteLine(student.Name);
        }

        public override string ToString()
    {
        return Name;
        return $"{Name} ({Students.Count}/{MaxSeats} platser)"; // Basics in the Course-class done
    }// unreachable code detected, sure i return it already yaa
        }


       

        }
    }
