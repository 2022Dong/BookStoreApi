using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreApi.Models;

public class Store
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    //[BsonElement("Name")]  // System.FormatException: Element 'StoreName' does not match any field or property of class BookStoreApi.Models.Store.
    [BsonElement("StoreName")]
    public string StoreName { get; set; }
    public string Location { get; set; }
    public int PostCode { get; set; }
}
