using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Models;
using CRUD.Services.Interface;

namespace CRUD.Services
{
    public class RegisterService : IGenericRegister
    {
        private List<Students> students = new List<Students>();
        private int _nextId = 0;
        public void AddStudent(Students student)
        {
            student.Id = ++_nextId;
            students.Add(student);

        }

        public bool DeleteStudent(int id)
        {          
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                return true;
            }
            return false;
        }

        public List<Students> GetAllStudents()
        {
            return students;
        }

        public Students GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public bool UpdateStudent(Students student)
        {
            var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.FirstName = student.FirstName;
                existingStudent.LastName = student.LastName;
                existingStudent.Age = student.Age;
                existingStudent.GroupName = student.GroupName;
                return true;
            }
            
            return false;
        }
    }
}
