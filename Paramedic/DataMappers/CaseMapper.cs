namespace Paramedic.DataMappers;

public class CaseMapper : IDataMapper
{
    private int Id { get; set; }
    private int Age { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    
    public Dictionary<string, dynamic> ToDictionary()
    {
        return new Dictionary<string, dynamic>()
        {
            {"id" , Id},
            {"age" , Age},
            {"first_name" , FirstName},
            {"last_name" , LastName},
        };
    }
}