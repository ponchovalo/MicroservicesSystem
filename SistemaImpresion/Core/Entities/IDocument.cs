using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace SistemaImpresion.Core.Entities
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
        DateTime CreateDate { get; }
    }
}
