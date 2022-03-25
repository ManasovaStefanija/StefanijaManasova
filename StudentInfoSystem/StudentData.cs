using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        private List<Student> TestStudents;

        public StudentData()
        {
            TestStudents = new List<Student>();
            TestStudents.Add(exampleStudent());
        }

        public List<Student> GetStudents()
        {
            return TestStudents;
        }

        private void SetStudents(List<Student> list)
        {
            TestStudents = list;
        }

        private Student exampleStudent()
        {
            Student student = new Student();
            student.Name = "Stefanija";
            student.Family = "Manasova";
            student.FacultyNumber = "123219003";
            student.Year = 3;
            student.Specialty = "KSI";
            return student;
        }
    }
}
