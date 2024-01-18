using DIP.Model;

namespace DIP.Factory;

class DbProductFactory {
    public static IDbProduct Create() {
        if (Environment.GetEnvironmentVariable("DB")! == "SQLSERVER")
            return new SQLServerProduct();

        return new MongoDBProduct();
    }
}