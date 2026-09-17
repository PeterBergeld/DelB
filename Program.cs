

Course course = new Course(); // Yeah dunno why i did 2x of tbh
course.Name = "Matematik";
course.MaxSeats = 2; 

Course programming = new Course();
programming.Name = "Programmering";
programming.MaxSeats = 3;

Student student = new Student(); // add the student
student.Name = "Peter";

student.Join(course);
student.Schedule();


// Second student , yeah that wasnt simplified? 
Student student2 = new Student
{
    Name = "Anna"
};
student2.Join(course); // The test to see so the student cant be added twice
// studnent = "Anna"


Student student3 = new Student(); // adds a third student and expect the course to be full 
student3.Name = "Erik";
student3.Join(course);



//Now whe wanna try to enroll directly from Course.Enroll

programming.Enroll(student2); // testing the synco in both directions .Add(this) .Remove(this)
programming.RollCall();
student2.Schedule();
programming.Remove(student2);
student2.Schedule();
student.Leave(course); // Now we are removing a student and going trou the list
student.Schedule(); // Testing, to write alot of "matematik" kurser to the list


// 22:02 Last commit for tday. There is a day tmw also





