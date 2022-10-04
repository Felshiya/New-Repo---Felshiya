using MongoDB.Data.Interfaces;
using MongoDB.Entities.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Bindings;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private IGateway _gateway;
        private string _collectionName = "Student";

        public StudentRepository(IGateway gateway)
        {
            _gateway = gateway;
        }
        public IEnumerable<Student> GetAll()
        {
            var result = _gateway.GetMongoDB().GetCollection<Student>(_collectionName)
                            .Find(new BsonDocument())
                            .ToList();
            return result;
        }

        public bool Save(Student entity)
        {
            _gateway.GetMongoDB().GetCollection<Student>(_collectionName)
                .InsertOne(entity);
            return true;
        }

        public Student Update(string id, Student entity)
        {
            var update = Builders<Student>.Update
                .Set(e => e.StudentName, entity.StudentName );

            var result = _gateway.GetMongoDB().GetCollection<Student>(_collectionName)
                .FindOneAndUpdate(e => e.Id == id, update);
            return result;
        }

        public bool Delete(string id)
        {
            var result = _gateway.GetMongoDB().GetCollection<Student>(_collectionName)
                         .DeleteOne(e => e.Id == id);
            return result.IsAcknowledged;
        }
    }
}
