
using MainApp.Interfaces;
using MainApp.Models;
using MainApp.Services;

/*
 using MainApp.Services;

IUserService userService = new UserService();

var user = new UserService();
userService.CreateUser(user);
*/

// IMultiFunctionPrinter printer = new MultiFunctionPrinter();

IPrivateCustomer privateCustomer = new PrivateCustomer
{
 Id = "1",
 Email = "Monakhrsn@gmail.com",
 FirstName = "Mona",
 LastName = "Ko",
};

ICompanyCustomer companyCustomer = new CompanyCustomer
{
 Id = "2",
 Email = "info@domain.com",
 CompanyName = "EPN Sverige AB"
};

List<ICustomer> customers = [];

customers.Add(privateCustomer);
customers.Add(companyCustomer);

foreach (var customer in customers)
{
 if (customer is IPrivateCustomer pc)
 {
  Console.WriteLine("--------Private Customer--------");
  Console.WriteLine($"Id:{pc.Id}");
  Console.WriteLine($"Email:{pc.Email}");
  Console.WriteLine($"First name:{pc.FirstName}");
  Console.WriteLine($"Last name:{pc.LastName}");
 }
 else if (customer is ICompanyCustomer cc)
 {
  Console.WriteLine("--------Company Customer--------");
  Console.WriteLine($"Id:{cc.Id}");
  Console.WriteLine($"Email:{cc.Email}");
  Console.WriteLine($"Company name:{cc.CompanyName}");
 }
}

Console.ReadKey();