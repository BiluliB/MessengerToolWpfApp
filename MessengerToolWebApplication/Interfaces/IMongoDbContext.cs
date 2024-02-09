using MessengerToolWebApplication.Data;
using MessengerToolWebApplication.Models;

namespace MessengerToolWebApplication.Interfaces
{
    /// <summary>
    /// Interface for MongoDb context
    /// </summary>
    public interface IMongoDbContext
    {
        CollectionWrapper<User> Users { get; }
    }
}