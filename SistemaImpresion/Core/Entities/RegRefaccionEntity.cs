using MongoDB.Bson.Serialization.Attributes;

namespace SistemaImpresion.Core.Entities
{
    [BsonCollection("regRefaccion")]
    public class RegRefaccionEntity : Document
    {
        [BsonElement("cantidad")]
        public int cantidad { get; set; }

        [BsonElement("fecha")]
        public string fecha { get; set; }

        [BsonElement("refaccion")]
        public RefaccionEntity Refaccion { get; set;}

        [BsonElement("impresora")]
        public ImpresoraEntity Impresora { get; set; }

        [BsonElement("contadores")]
        public ContadoresEntity Contadores { get; set; }

    }
}
