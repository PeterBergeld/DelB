using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

Course course = new Course(); // Yeah dunno why i did 2x of th
course.Name = "Matematik";
course.MaxSeats = 2; 

Student student = new Student(); // add the student
student.Name = "Peter";

student.Join(course);
course.RollCall();
student.Schedule();

// Second student
Student student2 = new Student();
student2.Name = "Anna";
student2.Join(course);
course.RollCall();

Student student3 = new Student(); // adds a third student and expect the course to be full 
student3.Name = "Erik";
student3.Join(course);

