using NSubstitute;
using MongoDB.Test.Framework;
using MongoDB.Business.Services;
using MongoDB.Data.Interfaces;

namespace MongoDB.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
