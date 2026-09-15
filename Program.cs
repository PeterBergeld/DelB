using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

Course math = new Course(); // Adds an object 
math.Name = "Matematik"; //Properties
math.MaxSeats = 2; 

Course course = new Course(); 
course.Name = "Matematik";
course.MaxSeats = 2; 

Student student = new Student(); // add the student
student.Name = "Peter";

student.Join(course);