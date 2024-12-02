using MainApp.Interfaces;

namespace MainApp.Models;

public class CompanyCustomer : ICompanyCustomer
{
    public string CompanyName { get; set; } = null!;
    public string Id { get; set; } = null!;
    public string Email { get; set; } = null!;
}