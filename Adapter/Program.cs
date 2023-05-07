using System.Text;
using System.Text.Json;
using Adapter.Domain;
using Adapter.Domain.Adaptor;

// Adaptor Design Pattern 
// it is used when we have two incompatible applications, that we need to integrate with each other, SO we are creating a middle layer between the two applications, which acts as a translator
//Legacy code integration: When you have an old codebase that has a different interface from the rest of your code and you want to integrate it with the new code.

// Third-party libraries: When you're using a third-party library that has a different interface than the one you need to use in your code.
// Reusability: When you want to reuse a class that doesn't have the interface you need, but you can't modify it.

// its disadvantage:- increasing the complexity of the code, by adding an extra layer, which needs to be maintained.  


var payrollCaclualtorUrl = "https://localhost:44361/api/Payrol/Caclulator";
var reader = new EmplyeesData();
var employees = reader.GetEmployees();

var client = new HttpClient();
foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, payrollCaclualtorUrl);
    var employeeAdaptor = new EmployeeAdaptor(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdaptor), Encoding.UTF8, "application/json");

    var response = await client.SendAsync(request);
    var responseJSON = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJSON);

    Console.WriteLine($"Salary: {salary}");
}