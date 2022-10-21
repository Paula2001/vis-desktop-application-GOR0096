namespace Paramedic;

public readonly record struct CaseDto(string FirstName, string LastName, string CaseAge, string CaseId)
{
    public string FullName => $"{FirstName} {LastName}";
    public int Id => Convert.ToInt32(CaseId);
    public int Age => Convert.ToInt32(CaseAge);

}