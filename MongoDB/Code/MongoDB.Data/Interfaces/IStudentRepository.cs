using MongoDB.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB.Data.Interfaces
{
    public interface IStudentRepository : IGetAll<Student>, ISave<Student>, IUpdate<Student, string>, IDelete<string>
    {
    }
}
