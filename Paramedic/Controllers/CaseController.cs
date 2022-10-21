using Paramedic.Models;

namespace Paramedic.Controllers;

public class CaseController
{
    private readonly CaseModel _model;
    
    public CaseController(CaseModel model)
    {
        this._model = model;
    }
    
    public void Create(string caseId, string caseAge, string firstName ,string lastName)
    {
        var c = new CaseDto(
            CaseId: caseId,
            CaseAge: caseAge, 
            FirstName: firstName, 
            LastName: lastName
        );
        
        this._model.Insert(c);
    }

    public void GetAllData()
    {
        var x = this._model.AllCases();
        Console.WriteLine(x[0]);
    }
}