using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;


namespace MongoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.ReadLine();

            MongoClient mClient = new MongoClient("mongodb+srv://carmorama:3ACA8VUc2BeUd4Ay@cluster0.yczecdu.mongodb.net/");

            var DataBase = mClient.GetDatabase("MongoDemo");
            var collection = DataBase.GetCollection<BsonDocument>("Oficinas");

            var filter = Builders<BsonDocument>.Filter.Eq("ciudad", "Valencia");

            var oficinaBson = collection.Find(filter).FirstOrDefault();

            var oficinaValencia = BsonSerializer.Deserialize<Oficina>(oficinaBson);

            Console.WriteLine(oficinaValencia.Ciudad);
            Console.ReadLine();
        }
    }
}
