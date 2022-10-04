using MongoDB.Business.Interfaces;
using MongoDB.Data.Interfaces;
using MongoDB.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB.Business.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository _StudentRepository;

        public StudentService(IStudentRepository StudentRepository)
        {
           this._StudentRepository = StudentRepository;
        }
        public IEnumerable<Student> GetAll()
        {
            return _StudentRepository.GetAll();
        }

        public Student Save(Student Student)
        {
            _StudentRepository.Save(Student);
            return Student;
        }

        public Student Update(string id, Student Student)
        {
            return _StudentRepository.Update(id, Student);
        }

        public bool Delete(string id)
        {
            return _StudentRepository.Delete(id);
        }

    }
}
