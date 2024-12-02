using MainApp.Interfaces;

namespace MainApp.Models;

public class PrivateCustomer : IPrivateCustomer
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
    