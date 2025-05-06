using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Services.Interface
{
    public interface IGenericRegister
    {
        void AddStudent(Students student);
        List<Students> GetAllStudents();
        Students GetStudentById(int id);
        bool UpdateStudent(Students student);
        bool DeleteStudent(int id);
    }
}
