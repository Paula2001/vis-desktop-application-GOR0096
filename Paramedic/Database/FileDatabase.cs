namespace Paramedic.Database;

public abstract class FileDatabase
{
    protected string IdColName = "id";
    
    public abstract FileDatabase Find();
    public abstract FileDatabase FindMany();
    public abstract List<Dictionary<string,dynamic>> All();
    public abstract FileDatabase Insert(string content); 
    public abstract bool Update();
    public abstract bool Delete();
    public abstract string Get();

    public FileDatabase SetIdColName(string colName)
    {
        this.IdColName = colName;
        return this;
    }
}