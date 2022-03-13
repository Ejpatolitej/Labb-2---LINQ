using Labb_2___LINQ.Data;
using Labb_2___LINQ.Models;


using SchoolDbContext Context = new SchoolDbContext();

Course course1 = new Course() { CourseName = "SUT21" };
Course course2 = new Course() { CourseName = "MUT20" };
Course course3 = new Course() { CourseName = "Ekonomiskt Oberoende 22" };

Class class1 = new Class() { ClassName = "Math" };
Class class2 = new Class() { ClassName = "Programmering 1" };
Class class3 = new Class() { ClassName = "Programmering 2" };
Class class4 = new Class() { ClassName = "Avancerad .NET" };
Class class5 = new Class() { ClassName = "Databaser" };

Student student1 = new Student() { StudentName = "Jack", StudentEmail = "jack@jack.com", CourseID = 1 };
Student student2 = new Student() { StudentName = "Emma", StudentEmail = "emma@emma.com", CourseID = 1 };
Student student3 = new Student() { StudentName = "Jonathan", StudentEmail = "jonathan@jonathan.com", CourseID = 2 };
Student student4 = new Student() { StudentName = "Alice", StudentEmail = "alice@alice.com", CourseID = 3 };
Student student5 = new Student() { StudentName = "Timothy", StudentEmail = "timothy@timothy.com", CourseID = 1 };

Teacher teacher1 = new Teacher() { TeacherName = "Anas", TeacherEmail = "anas@qlok.com" };
Teacher teacher2 = new Teacher() { TeacherName = "Tobias", TeacherEmail = "tobias@qlok.com" };
Teacher teacher3 = new Teacher() { TeacherName = "Reidar", TeacherEmail = "reidar@qlok.com" };

TeacherClass teacherClass1 = new TeacherClass() { fkClassID = 1, fkTeacherID = 1 };
TeacherClass teacherClass2 = new TeacherClass() { fkClassID = 2, fkTeacherID = 1 };
TeacherClass teacherClass3 = new TeacherClass() { fkClassID = 3, fkTeacherID = 1 };
TeacherClass teacherClass4 = new TeacherClass() { fkClassID = 4, fkTeacherID = 2 };
TeacherClass teacherClass5 = new TeacherClass() { fkClassID = 5, fkTeacherID = 3 };
TeacherClass teacherClass6 = new TeacherClass() { fkClassID = 2, fkTeacherID = 2 };

CourseClass courseClass1 = new CourseClass() { fkCourseID = 1, fkClassID = 1 };
CourseClass courseClass2 = new CourseClass() { fkCourseID = 1, fkClassID = 3 };
CourseClass courseClass3 = new CourseClass() { fkCourseID = 1, fkClassID = 4 };
CourseClass courseClass4 = new CourseClass() { fkCourseID = 1, fkClassID = 5 };
CourseClass courseClass5 = new CourseClass() { fkCourseID = 2, fkClassID = 2 };
CourseClass courseClass6 = new CourseClass() { fkCourseID = 3, fkClassID = 5 };

Context.SaveChanges();

#region Adding Data to Tables

//Context.Courses.AddRange(course1, course2, course3);
//Context.Classes.AddRange(class1, class2, class3, class4, class5);
//Context.Students.AddRange(student1, student2, student3, student4, student5);
//Context.Teachers.AddRange(teacher1, teacher2, teacher3);
//Context.TeacherClasses.AddRange(teacherClass1, teacherClass2, teacherClass3, teacherClass4, teacherClass5, teacherClass6);
//Context.CourseClasses.AddRange(courseClass1, courseClass2, courseClass3, courseClass4, courseClass5, courseClass6);

//Context.SaveChanges();

#endregion

List<Teacher> teacherList = new List<Teacher>() { teacher1, teacher2, teacher3 };
List<Student> studentList = new List<Student>() { student1, student2, student3, student4, student5 };
List<Class> classList = new List<Class>() { class1, class2, class3, class4, class5 };
List<Course> courseList = new List<Course>() { course1, course2, course3 };
List<TeacherClass> teacherClassList = new List<TeacherClass>() { teacherClass1, teacherClass2, teacherClass3, teacherClass4, teacherClass5, teacherClass6 };
List<CourseClass> courseClassList = new List<CourseClass>() { courseClass1, courseClass2, courseClass3, courseClass4, courseClass5, courseClass6 };

//Hämta alla lärare i Matte
IEnumerable<TeacherClass> OOPTeachers = teacherClassList.Where(t => t.Class == class1).ToList();
foreach (var item in OOPTeachers)
{
    Console.WriteLine("Lärare i Matte: " + item.Teacher.TeacherName);
}

Console.WriteLine("\n-------------------------------------------------------------\n");

//Hämta alla lärare med elever

//var teachStud = from teach in teacherList
//                join stud in studentList
//                on teach.TeacherID equals stud.StudentID
//                into STGroup
//                select new { teach, STGroup };

//foreach (var t in teachStud)
//{
//    Console.WriteLine("Teacher: " + t.teach.TeacherName);
//    foreach (var s in t.STGroup)
//    {
//        Console.WriteLine(" Student: " + s.StudentName);
//    }
//    Console.WriteLine();
//}

//var teachStud = from teach in teacherList
//                join tc in teacherClassList
//                on teach.TeacherID equals tc.TeacherClassID
//                join cl in classList
//                on tc.TeacherClassID equals cl.ClassID
//                join cc in courseClassList
//                on cl.ClassID equals cc.CourseClassID
//                join co in courseList
//                on cc.CourseClassID equals co.CourseID
//                join stud in studentList
//                on co.CourseID equals stud.StudentID
//                select new { 

//                    teachName = teach.TeacherName,
//                    studName = stud.StudentName

//                };

//foreach (var t in teachStud)
//{
//    Console.WriteLine("Teacher: " + t.teachName);
//    foreach (var s in t)
//    {
//        Console.WriteLine(" Student: " + s);
//    }
//    Console.WriteLine();
//}

//var studTeach = from stud in studentList
//                join co in courseList
//                on stud.StudentID equals co.CourseID
//                join cc in courseClassList
//                on co.CourseID equals cc.CourseClassID
//                join cl in classList
//                on cc.CourseClassID equals cl.ClassID
//                join tc in teacherClassList
//                on cl.ClassID equals tc.TeacherClassID
//                join teach in teacherList
//                on tc.TeacherClassID equals teach.TeacherID
//                into studGroup
//                select new { stud, studGroup };
//foreach (var item in studTeach)
//{
//    Console.WriteLine("Student: " + item.stud.StudentName);
//    foreach (Teacher t in item.studGroup)
//    {
//        Console.WriteLine("Teacher: " + t.TeacherName);
//    }
//    Console.WriteLine();
//}

Console.WriteLine("\n-------------------------------------------------------------\n");

//Kolla om ämnet finns i tabell
var checkClass = classList.Where(c => c.ClassName == "Programmering 1");

if (checkClass == null)
{
    Console.WriteLine("Programmering 1 finns inte i listan");
}
else
{
    Console.WriteLine("Programmering 1 finns i listan");
}

Console.WriteLine("\n-------------------------------------------------------------\n");

//Ändra Ämne
IEnumerable<Class> changeClass = classList.Where(c => c.ClassName == "Programmering 1").ToList();
foreach (var item in changeClass)
{
    if (item.ClassName == "Programmering 1")
    {
        item.ClassName = "OOP";
    }
}
foreach (var item in classList)
{
    Console.WriteLine(item.ClassName);
}
//Context.SaveChanges();

Console.WriteLine("\n-------------------------------------------------------------\n");

//Ändra lärare
IEnumerable<Teacher> changeTeacher = teacherList.Where(t => t.TeacherName == "Anas").ToList();
foreach (var item in changeTeacher)
{
    if (item.TeacherName == "Anas")
    {
        item.TeacherName = "Reidar";
    }
}
foreach (var item in teacherList)
{
    Console.WriteLine(item.TeacherName);
}
//Context.SaveChanges();
