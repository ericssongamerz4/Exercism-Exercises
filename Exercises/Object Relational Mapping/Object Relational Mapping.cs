public class Orm : IDisposable
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Begin() => database.BeginTransaction();

    public void Write(string data)
    {
        try
        {
            database.Write(data);
        }
        catch
        {
            Dispose();
        }
    }

    public void Commit()
    {
        try
        {
            database.EndTransaction();
        }
        catch (Exception)
        {
            Dispose();
        }

    }
    public void Dispose() => database.Dispose();
}

//This is part of the exercise just added it so there aren't any errors 
public class Database
{
    internal void BeginTransaction()
    {
        throw new NotImplementedException();
    }

    internal void Dispose()
    {
        throw new NotImplementedException();
    }

    internal void EndTransaction()
    {
        throw new NotImplementedException();
    }

    internal void Write(string data)
    {
        throw new NotImplementedException();
    }
}





//Made by ericssonGamerz4            