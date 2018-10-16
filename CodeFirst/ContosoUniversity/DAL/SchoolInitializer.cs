using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{LastName="Alexander",FirstMidName="Carson",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{LastName="Alonso",FirstMidName="Meredith",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{LastName="Anand",FirstMidName="Arturo",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{LastName="Barzdukas",FirstMidName="Gytis",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{LastName="Li",FirstMidName="Yan",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{LastName="Justice",FirstMidName="Peggy",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{LastName="Norman",FirstMidName="Laura",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{LastName="Olivetto",FirstMidName="Nino",EnrollmentDate=DateTime.Parse("2005-09-01")},
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var instructors = new List<Instructor>
            {
                new Instructor{LastName="Sánchez",FirstMidName="Ken",HireDate=Convert.ToDateTime("2008-10-21")},
                new Instructor{LastName="Duffy",FirstMidName="Terri",HireDate=Convert.ToDateTime("2007-11-07")},
                new Instructor{LastName="Tamburello",FirstMidName="Roberto",HireDate=Convert.ToDateTime("2007-08-18")},
                new Instructor{LastName="Walters",FirstMidName="Rob",HireDate=Convert.ToDateTime("2007-09-11")},
                new Instructor{LastName="Erickson",FirstMidName="Gail",HireDate=Convert.ToDateTime("2007-10-13")},
                new Instructor{LastName="Goldberg",FirstMidName="Jossef",HireDate=Convert.ToDateTime("2013-09-29")},
                new Instructor{LastName="Gibson",FirstMidName="Mary",HireDate=Convert.ToDateTime("2008-10-19")},
                new Instructor{LastName="Williams",FirstMidName="Jill",HireDate=Convert.ToDateTime("2008-10-25")},
                new Instructor{LastName="Hamilton",FirstMidName="James",HireDate=Convert.ToDateTime("2008-11-10")},
                new Instructor{LastName="Krebs",FirstMidName="Peter",HireDate=Convert.ToDateTime("2008-09-07")},
                new Instructor{LastName="Brown",FirstMidName="Jo",HireDate=Convert.ToDateTime("2007-12-04")},
                new Instructor{LastName="Gilbert",FirstMidName="Guy",HireDate=Convert.ToDateTime("2006-04-06")},
                new Instructor{LastName="McArthur",FirstMidName="Mark ",HireDate=Convert.ToDateTime("2008-10-30")},
                new Instructor{LastName="Simon",FirstMidName="Britta",HireDate=Convert.ToDateTime("2008-11-05")},
                new Instructor{LastName="Shoop",FirstMidName="Margie",HireDate=Convert.ToDateTime("2008-10-11")},
                new Instructor{LastName="Laszlo",FirstMidName="Rebecca",HireDate=Convert.ToDateTime("2008-10-05")},
                new Instructor{LastName="Stahl",FirstMidName="Annik",HireDate=Convert.ToDateTime("2008-09-23")},
            };
            instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department{Name="Engineering",Budget=56421,StartDate=Convert.ToDateTime("2007-09-13"), InstructorID=9},
                new Department{Name="Tool Design",Budget=13212,StartDate=Convert.ToDateTime("2008-10-28"), InstructorID=10},
                new Department{Name="Sales",Budget=74232,StartDate=Convert.ToDateTime("2006-09-23"), InstructorID=11},
                new Department{Name="Marketing",Budget=48761,StartDate=Convert.ToDateTime("2018-09-23"), InstructorID=12},
                new Department{Name="Purchasing",Budget=62331,StartDate=Convert.ToDateTime("2014-02-23"), InstructorID=13},
                new Department{Name="Research and Development",Budget=45954,StartDate=Convert.ToDateTime("2008-09-23"), InstructorID=14},
                new Department{Name="Production",Budget=48796,StartDate=Convert.ToDateTime("2016-01-12"), InstructorID=15},
                new Department{Name="Production Control",Budget=49743,StartDate=Convert.ToDateTime("2012-05-23"), InstructorID=16},
                new Department{Name="Human Resources",Budget=35286,StartDate=Convert.ToDateTime("2008-04-23"), InstructorID=17},
                new Department{Name="Finance",Budget=47776,StartDate=Convert.ToDateTime("2008-09-23"), InstructorID=18},
                new Department{Name="Information Services",Budget=42121,StartDate=Convert.ToDateTime("2008-09-20"), InstructorID=19},
                new Department{Name="Document Control",Budget=42286,StartDate=Convert.ToDateTime("2015-09-15"), InstructorID=20},
                new Department{Name="Quality Assurance",Budget=98576,StartDate=Convert.ToDateTime("2011-09-15"), InstructorID=21},
                new Department{Name="Facilities and Maintenance",Budget=52525,StartDate=Convert.ToDateTime("2009-09-12"), InstructorID=22},
                new Department{Name="Shipping and Receiving",Budget=44296,StartDate=Convert.ToDateTime("2008-09-23"), InstructorID=23},
                new Department{Name="Executive",Budget=45286,StartDate=Convert.ToDateTime("2008-09-23"), InstructorID=24},
                new Department{Name="Executive Authoritative",Budget=22222,StartDate=Convert.ToDateTime("2008-09-01"), InstructorID=25},
            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID=1,Title="Chemistry",Credits=3,DepartmentID=1},
                new Course{CourseID=2,Title="Microeconomics",Credits=3,DepartmentID=2},
                new Course{CourseID=3,Title="Macroeconomics",Credits=3,DepartmentID=3},
                new Course{CourseID=4,Title="Calculus",Credits=4,DepartmentID=4},
                new Course{CourseID=5,Title="Trigonometry",Credits=4,DepartmentID=5},
                new Course{CourseID=6,Title="Composition",Credits=3,DepartmentID=6},
                new Course{CourseID=7,Title="Art",Credits=4,DepartmentID=7},
                new Course{CourseID=8,Title="Music",Credits=4,DepartmentID=8},
                new Course{CourseID=9,Title="Social studies",Credits=4,DepartmentID=9},
                new Course{CourseID=10,Title="Civics and government",Credits=4,DepartmentID=10},
                new Course{CourseID=11,Title="History",Credits=4,DepartmentID=11},
                new Course{CourseID=12,Title="Geography",Credits=4,DepartmentID=12},
                new Course{CourseID=13,Title="English",Credits=4,DepartmentID=13},
                new Course{CourseID=14,Title="Mathematics",Credits=4,DepartmentID=14},
                new Course{CourseID=15,Title="Science",Credits=4,DepartmentID=15},
                new Course{CourseID=16,Title="Accounting",Credits=4,DepartmentID=16},
                new Course{CourseID=17,Title="Business",Credits=4,DepartmentID=17},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=5,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=7,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=12,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=16,Grade=Grade.E},
                new Enrollment{StudentID=1,CourseID=17,Grade=Grade.F},

                new Enrollment{StudentID=2,CourseID=2,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=5,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=11,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=12,Grade=Grade.E},
                new Enrollment{StudentID=2,CourseID=14,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=16,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=17,Grade=Grade.F},

                new Enrollment{StudentID=3,CourseID=6},
                new Enrollment{StudentID=3,CourseID=8,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=9},
                new Enrollment{StudentID=3,CourseID=10,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=13,Grade=Grade.C},
                new Enrollment{StudentID=3,CourseID=14},

                new Enrollment{StudentID=4,CourseID=1,},
                new Enrollment{StudentID=4,CourseID=4,Grade=Grade.A},
                new Enrollment{StudentID=4,CourseID=5,Grade=Grade.B},
                new Enrollment{StudentID=4,CourseID=7,},
                new Enrollment{StudentID=4,CourseID=10,},
                new Enrollment{StudentID=4,CourseID=14,Grade=Grade.F},

                new Enrollment{StudentID=5,CourseID=4,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=8,Grade=Grade.E},
                new Enrollment{StudentID=5,CourseID=9,Grade=Grade.D},
                new Enrollment{StudentID=5,CourseID=11,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=12,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=15,Grade=Grade.B},
                new Enrollment{StudentID=5,CourseID=16,Grade=Grade.C},
                new Enrollment{StudentID=5,CourseID=17,Grade=Grade.C},

                new Enrollment{StudentID=6,CourseID=1,Grade=Grade.A},
                new Enrollment{StudentID=6,CourseID=2,Grade=Grade.A},
                new Enrollment{StudentID=6,CourseID=3,Grade=Grade.B},
                new Enrollment{StudentID=6,CourseID=15},
                new Enrollment{StudentID=6,CourseID=17},

                new Enrollment{StudentID=7,CourseID=5,Grade=Grade.A},
                new Enrollment{StudentID=7,CourseID=6,Grade=Grade.B},
                new Enrollment{StudentID=7,CourseID=7,Grade=Grade.A},
                new Enrollment{StudentID=7,CourseID=8,Grade=Grade.E},
                new Enrollment{StudentID=7,CourseID=11,Grade=Grade.C},
                new Enrollment{StudentID=7,CourseID=12,Grade=Grade.B},
                new Enrollment{StudentID=7,CourseID=15,Grade=Grade.B},
                new Enrollment{StudentID=7,CourseID=16,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}