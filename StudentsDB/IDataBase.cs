using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsDB
{
    public interface IDataBase
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentByID(int id);

        void UpdateStudent(int id, Student student);


    }
}
