// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using Paramedic.Controllers;
using Paramedic.Database;
using Paramedic.Models;

string command = "" ;

Dictionary<string, string> commands = new Dictionary<string, string>();
commands.Add("end","Type 'end' to end the execution of the program");
commands.Add("all","Type 'all' to get all data in the program");
commands.Add("insert","Type 'insert' to insert new data");
commands.Add("update","Type 'update' to update data");
commands.Add("delete","Type 'delete' to delete data");

string allOfTheCommands = string.Format("{0}\n{1}\n{2}\n{3}", commands["insert"], commands["update"],
    commands["delete"], commands["end"]);

Console.WriteLine(allOfTheCommands);
FileDatabase jsonDatabase = new JsonDatabase();
var caseController = new CaseController(new CaseModel(jsonDatabase));


while (command != "end")
{
    command = Strings.Trim(Console.ReadLine() ?? "");
    
    switch (command)
    {
        case "insert":
            var insertionRequests = new[] { 
                "Insert Id of case.",
                "Insert Age.", 
                "Insert First Name.",
                "Insert Last Name." 
            };
            var inputData = new List<string>();
            foreach (var insertionRequest in insertionRequests)
            {
                Console.WriteLine(insertionRequest);
                inputData.Add(Console.ReadLine());
            }
            
            caseController.Create(
            inputData[0],
            inputData[1],
            inputData[2],
            inputData[3]
            );
            
            Console.Clear();
            Console.WriteLine(allOfTheCommands);

            break;
        case "add":
            caseController.GetAllData();
            break;
        default:
            Console.Clear();
            Console.WriteLine("No valid command was entered \n");
            Console.WriteLine(allOfTheCommands);
            break;
    }
}



// string x = Console.ReadLine();
// Console.WriteLine(Convert.ToInt32(x) + 1);
