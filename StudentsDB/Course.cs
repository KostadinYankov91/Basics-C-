using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsDB
{
    public class Course
    {
        private IDataBase database;

        public Course(IDataBase db)
        {
            database = db;
        }

        public void SighStudent(int studentId)
        {
            Student student = database.GetStudentByID(studentId);
        }

        public void RegisterStudent(Student student)
        {

        }

        public void DispalyAllStudents()
        {
            foreach (var student in database.GetAllStudents())
            {

                Console.WriteLine(student);
            }
        }
    }
}
