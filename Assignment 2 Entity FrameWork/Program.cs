using assignment_1_entity_frame_work.Entities;
using Assignment_2_Entity_FrameWork.Context;

namespace Assignment_2_Entity_FrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ITI_EFW_Context())
            {
                // Create a new student
                //var student = new Student { FirstName = "Bassim", LastName = "Ahmed", StudentAddress = "123 Main St", StudentAge = 20, DepartmentId = 1 };
                //context.Student.Add(student);


                //// Create a new department
                //var department = new Department { DepartmentName = "Computer Science", InstructorId = 1, InstructorHiringDate = DateTime.Now };
                //context.Department.Add(department);


                //// Create a new course
                //var course = new Course { Duration = 3, Name = "C#", Description = "C# Programming", Top_ID = 1 };
                //context.Course.Add(course);

                //// Create a new instructor
                //var instructor = new Instructor { Name = "Ali", Salary = 50000, Address = "456 main St", HourRate = 50, Bouns = 1000, Dept_ID = 1 };
                //context.Instructor.Add(instructor);


                //// Create a new topic
                //var topic = new Topic { Name = "Entity Framework Core" };
                //context.Topic.Add(topic);


                //// Create a new student-course 
                //var studCourse = new Stud_Course { stud_ID = 1, Course_ID = 1, Grade = "A" };
                //context.Stud_Course.Add(studCourse);


                //// Create a new course-instructor 
                //var courseInst = new Course_Inst { inst_ID = 1, Course_ID = 1 };
                //context.Course_Inst.Add(courseInst);
                //context.SaveChanges();


                //// Read all students
                //var students = context.Student.ToList();
                //foreach (var item in students)
                //{
                //    Console.WriteLine(item.StudentAge);
                //}

                //// Read all departments
                //var departments = context.Department.ToList();

                //// Read all courses
                //var courses = context.Course.ToList();

                //// Read all instructors
                //var instructors = context.Instructor.ToList();

                //// Read all topics
                //var topics = context.Topic.ToList();

                //// Read all student-course relationships
                //var studCourses = context.Stud_Course.ToList();

                //// Read all course-instructor relationships
                //var courseInsts = context.Course_Inst.ToList();




                //// Update a student
                //var studentToUpdate = context.Student.Find(1);
                //studentToUpdate.FirstName = "magdy";


                //// Update a department
                //var departmentToUpdate = context.Department.Find(1);
                //departmentToUpdate.DepartmentName = "Computer Science and Engineering";


                //// Update a course
                //var courseToUpdate = context.Course.Find(1);
                //courseToUpdate.Duration = 4;


                //// Update an instructor
                //var instructorToUpdate = context.Instructor.Find(1);
                //instructorToUpdate.Salary = 60000;


                //// Update a topic
                //var topicToUpdate = context.Topic.Find(1);
                //topicToUpdate.Name = "Entity Framework Core 3.1";

                //context.SaveChanges();

               /////Delete student
               // var studentToDelete = context.Student.Find(1);
               // context.Student.Remove(studentToDelete);
                

               // // Delete a department
               // var departmentToDelete = context.Department.Find(1);
               // context.Department.Remove(departmentToDelete);
                

               // // Delete a course
               // var courseToDelete = context.Course.Find(1);
               // context.Course.Remove(courseToDelete);
               

               // // Delete an instructor
               // var instructorToDelete = context.Instructor.Find(1);
               // context.Instructor.Remove(instructorToDelete);
              

               // // Delete a topic
               // var topicToDelete = context.Topic.Find(1);
               // context.Topic.Remove(topicToDelete);
               // context.SaveChanges();


            }
        }
    }
}
