using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.TestData
{
    static public class StudentData
    {
        static public List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return _testStudents;
            }
            set { }
        }

        static private List<Student> _testStudents;

        static private void ResetTestStudentData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>
                {
                    new Student
                    {
                        FirstName = "Stefanija",
                        SecondName = "",
                        LastName = "Manasova",
                        Faculty = "FCST",
                        Major = "CSE",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123219003",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                    new Student
                    {
                        FirstName = "Ivan",
                        SecondName = "",
                        LastName = "Ivanov",
                        Faculty = "FCST",
                        Major = "CSE",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123456789",
                        Course = 1,
                        Stream = 9,
                        Group = 33,
                    },
                    
                };
            }
        }
    }
}