using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDemo
{
    [BsonIgnoreExtraElements]
    public class Oficina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("codOficina")]
        public string CodOficina { get; set; }

        [BsonElement("ciudad")]
        public string Ciudad { get; set; }

        [BsonElement("pais")]
        public string Pais { get; set; }

        [BsonElement("codPostal")]
        public string CodPostal { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("linea_direccion1")]
        public string LineaDireccion1 { get; set; }

        [BsonElement("linea_direccion2")]
        public string LineaDireccion2 { get; set; }
    }
}
