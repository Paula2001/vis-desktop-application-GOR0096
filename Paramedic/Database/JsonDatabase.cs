using System.Text.Json;
using System.Text.Json.Nodes;

namespace Paramedic.Database;

using System.IO;
public class JsonDatabase : FileDatabase
{
    private const string FilePath = "/home/paula/RiderProjects/Paramedic/Database.json"; // TODO : update the path please.
    public override List<Dictionary<string,dynamic>> All()
    {
        var readText = File.ReadAllText(FilePath); // TODO return dynamic
        var fileData = JsonObject.Parse(readText).AsObject();
        var cases = new List<Dictionary<string,dynamic>>();
        foreach (var fileDatum in fileData)
        {
            var oneCase = new Dictionary<string, dynamic>()
            {
                {fileDatum.Key,fileDatum.Value}
            };
            cases.Add(oneCase);
        }
        return cases;
    }

    public override bool Delete()
    {
        return true;
    }

    public override JsonDatabase Find()
    {
        return this;
    }

    public override string Get()
    {
        return "";
    }

    public override JsonDatabase Insert(string content)
    {
        // TODO if the files is not exist create ,create a file with {}
        var readText = File.ReadAllText(FilePath);
        JsonNode fileData = JsonObject.Parse(readText);
        JsonNode userData = JsonObject.Parse(content).AsObject();

        if (userData[this.IdColName] == null)
        {
            throw new Exception("Column of the id is not found");
        }
        
        try
        {
            var id = Convert.ToString(userData[this.IdColName]);
            var newData = new KeyValuePair<string, JsonNode>(id,userData);
            fileData.AsObject().Add(newData);
            var writeText = JsonSerializer.Serialize(fileData);
            File.WriteAllText(FilePath, writeText);
        } catch (ArgumentException e) {
            throw new Exception($"Insertion issue due to : {e.Message}");
        }
        return this;
    }

    public override bool Update()
    {
        return true;
    }

    public override JsonDatabase FindMany()
    {
        return this;
    }
}

// public void All()
// {
//     string readText = File.ReadAllText(FilePath);
//     Console.WriteLine(readText);
//     throw new NotImplementedException();
// }
//
// public string Find(int id)
// {
//     throw new NotImplementedException();
// }
//
// public bool Delete(int id)
// {
//     throw new NotImplementedException();
// }
//
//
// public bool Update()
// {
//     throw new NotImplementedException();
// }
