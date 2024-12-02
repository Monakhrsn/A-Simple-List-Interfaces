namespace MainApp.Interfaces;

public interface IPrivateCustomer : ICustomer
{ 
    string FirstName { get; set; }
    string LastName { get; set; }
}