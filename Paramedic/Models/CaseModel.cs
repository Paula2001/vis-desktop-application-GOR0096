namespace Paramedic.Models;

using System.Text.Json;
using Paramedic;
using Paramedic.Database;
using Paramedic.DataMappers;

public class CaseModel
{
    private readonly FileDatabase _connection;

    private int id;
    private int age;
    private string lastName;
    private string firstName;
    
    public CaseModel(FileDatabase c)
    {
        this._connection = c;
        this._connection.SetIdColName("Id");
    }

    public void Insert(CaseDto c)
    {
        this._connection.Insert(JsonSerializer.Serialize(c));
    }

    public List<Dictionary<string,dynamic>> AllCases()
    {
        return this._connection.All();
    }
    
}