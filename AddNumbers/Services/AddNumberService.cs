using MongoDB.Driver;
using MongoDB.Bson;
public class AddNumberService : IAddNumberService
{
    public async Task<ResultDTO> AddNumber(AddNumDTO dto)
    {
       ResultDTO resDTO = new ResultDTO()
       {
            Num1 = dto.Num1,
            Num2 = dto.Num2,
            Result = dto.Num1 + dto.Num2
       };
        //add mongo db stuff
        MongoClient client = new MongoClient("mongodb://mongo_db:27017");
        var db = client.GetDatabase("NumDB");
        var collection = db.GetCollection<BsonDocument>("Numbers");
        BsonDocument doc = new BsonDocument()
        {
            {"Num1", dto.Num1},
            {"Num2", dto.Num2},
            {"Result:", resDTO.Result}

        };
        collection.InsertOne(doc);

       return resDTO;
    }
}