using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PortafolioASA.Models
{
     public class PortafolioModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get; set;} = string.Empty;
        
        [BsonElement("nombre")]
        public string Nombre {get;set;} = string.Empty;

        [BsonElement("edad")]
        public string Edad {get; set;} = string.Empty;

        [BsonElement("telefono")] 
        public string Telefono {get; set;} = string.Empty;

        [BsonElement("descripcion")]
        public string Descripcion {get; set;} = string.Empty;

        [BsonElement("correo")]
         public string Correo {get; set;} = string.Empty;

    }
}