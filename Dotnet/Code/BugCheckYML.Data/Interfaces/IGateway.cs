using MongoDB.Driver;

namespace BugCheckYML.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
