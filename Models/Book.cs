using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Book
    {
        [BsonId] //designiar o Id como promary key
        [BsonRepresentation(BsonType.ObjectId)] //Aqui é permitir passa como parâmetro string e o mongo transforma no objeto ObjectId
        public string Id { get; set; }

        [BsonElement("Name")] //Elemento que representa a propriedade Name dentro da collection do MongoDB
        [JsonProperty("Name")] //Representa o nome da propriedade no retorno JSON serializado da WebApi
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}