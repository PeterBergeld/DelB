using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

Course course = new Course(); // Yeah dunno why i did 2x of th
course.Name = "Matematik";
course.MaxSeats = 2; 

Course programming = new Course();
programming.Name = "Programmering";
programming.MaxSeats = 3;

Student student = new Student(); // add the student
student.Name = "Peter";

student.Join(course);
course.RollCall();
student.Schedule();
student.Leave(course); // Now we are removing a student and going trou the list
student.Schedule();
student.Leave(course); // and the last one, better leaves the course

// Second student
Student student2 = new Student();
student2.Name = "Anna";
student2.Join(course);
course.RollCall();
student2.Join(course); // The test to seee so the student cant be added twice


Student student3 = new Student(); // adds a third student and expect the course to be full 
student3.Name = "Erik";
student3.Join(course);


//Now whe wanna try to enroll directly from Course.Enroll

programming.Enroll(student2);
programming.RollCall();
