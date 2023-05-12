using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SistemaImpresion.Core.Entities
{
    [BsonCollection("refaccion")]
    public class RefaccionEntity : Document
    {
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("noParte")]
        public string NoParte { get; set; }

        [BsonElement("modeloImp")]
        public string ModeloImp { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; }

        [BsonElement("vidaUtil")]
        public int VidaUtil { get; set; }

        [BsonElement("cantidad")]
        public int Cantidad { get; set; }    
    }
}
