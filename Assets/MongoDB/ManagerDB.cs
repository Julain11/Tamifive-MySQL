using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;
using MongoDB.Driver;

public class ManagerDB : MonoBehaviour
{
    private static string MONGO_URI = "mongodb://neurotesis:neurotesis@cluster0-shard-00-00.3i7sz.mongodb.net:27017,cluster0-shard-00-01.3i7sz.mongodb.net:27017,cluster0-shard-00-02.3i7sz.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=atlas-hyzugr-shard-0&authSource=admin&retryWrites=true&w=majority";
    private static string DATABASE_NAME = "Tamizaje";    
    private static MongoClient client;
    private static IMongoDatabase db;
        public async static void conectar() 
    {
        client = new MongoClient(MONGO_URI); 
        db = client.GetDatabase(DATABASE_NAME); 
    }
    public async static void insertar(string NomPAs, string EdadPAs, string InstPass, string NomPro,  string CorrepPro, string InstPro,  string Nivel, float Score)
    {
        var userCollec = db.GetCollection<BsonDocument>("informcion");
        var document = new BsonDocument
        {
            {"NomPAs", BsonValue.Create(NomPAs)},
            {"EdadPAs", BsonValue.Create(EdadPAs)},
            {"InstPass", BsonValue.Create(InstPass)},
            {"NomPro", BsonValue.Create(NomPro)},
            {"CorrepPro", BsonValue.Create(CorrepPro)},
            {"InstPro", BsonValue.Create(InstPro)},            
            {"Nivel", BsonValue.Create(Nivel)},
            {"Score", BsonValue.Create(Score)}

        };
        await userCollec.InsertOneAsync(document);
    }
    public async static void insertarprueba(string NomPAs, string apePAs, string EdadPAs, string GradoPass, string NomPro, string CorrepPro, string ProApellido, string Nivel, float correct, float incorrect, float time)
    {
        var userCollec = db.GetCollection<BsonDocument>(EstadoJuego.estadoJuego.PacienteNombre);
        var document = new BsonDocument
        {
            {"NomPAs", BsonValue.Create(NomPAs)},
            {"ApePAs", BsonValue.Create(apePAs)},
            {"EdadPAs", BsonValue.Create(EdadPAs)},
            {"GradoPass", BsonValue.Create(GradoPass)},
            {"NomPro", BsonValue.Create(NomPro)},
            {"CorrepPro", BsonValue.Create(CorrepPro)},
            {"ProApellido", BsonValue.Create(ProApellido)},
            {"Nivel", BsonValue.Create(Nivel)},
            {"correcto", BsonValue.Create(correct)},
            {"incorrecto", BsonValue.Create(incorrect)},
            {"tiempo", BsonValue.Create(time)}


        };
        await userCollec.InsertOneAsync(document);
    }
    void Start()
    {
        
    }

    
    
}
