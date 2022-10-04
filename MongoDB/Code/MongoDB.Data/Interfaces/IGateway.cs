using MongoDB.Driver;

namespace MongoDB.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
