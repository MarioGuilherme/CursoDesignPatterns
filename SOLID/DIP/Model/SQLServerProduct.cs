namespace DIP.Model;

class SQLServerProduct : IDbProduct {
    public string GetProductById(string id) {
        return $"SQLServer: Exibindo dados do produto {id}";
    }
}