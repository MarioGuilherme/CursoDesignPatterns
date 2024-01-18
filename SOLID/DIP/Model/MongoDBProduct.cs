namespace DIP.Model;

class MongoDBProduct : IDbProduct {
    public string GetProductById(string id) {
        return $"MongoDB: Exibindo dados do produto {id}";
    }
}