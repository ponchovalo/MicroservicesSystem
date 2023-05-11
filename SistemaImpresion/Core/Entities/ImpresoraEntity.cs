using MongoDB.Bson.Serialization.Attributes;

namespace SistemaImpresion.Core.Entities
{
    [BsonCollection("impresora")]
    public class ImpresoraEntity : Document
    {
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("modelo")]
        public string Modelo { get; set; }
        [BsonElement("serie")]
        public string Serie { get; set; }
        [BsonElement("ip")]
        public string Ip { get; set; }
        [BsonElement("mac")]
        public string Mac { get; set; }
        [BsonElement("edificio")]
        public string Edificio { get; set; }
        [BsonElement("ubicacion")]
        public string Ubicacion { get; set; }
    }
}
