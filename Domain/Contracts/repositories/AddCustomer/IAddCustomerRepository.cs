using Domain.Entities;

namespace Domain.Contracts.repositories.AddCustomer;

public interface IAddCustomerRepository
{
    void AddCustomer(Customer customer);
}