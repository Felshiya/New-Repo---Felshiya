using MongoDB.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB.Business.Interfaces
{
    public interface IStudentService
    {      
        IEnumerable<Student> GetAll();
        Student Save(Student classification);
        Student Update(string id, Student classification);
        bool Delete(string id);

    }
}
