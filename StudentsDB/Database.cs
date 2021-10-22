using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsDB
{
    public class Database : IDataBase
    {
        public IEnumerable<Student> GetAllStudents()
        {

            return null;
        }

        public Student GetStudentByID(int id)
        {
            // goes to DB goes to SQL, searches for the student, maps the found student
            return null;
        }

        public void UpdateStudent(int id, Student student)
        {
            return null;
        }
    }
}
