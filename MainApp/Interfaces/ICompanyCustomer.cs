namespace MainApp.Interfaces;

public interface ICompanyCustomer : ICustomer
{
    string CompanyName { get; set; }
}