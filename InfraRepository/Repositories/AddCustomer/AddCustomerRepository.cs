using Dapper;
using Domain.Contracts.repositories.AddCustomer;
using Domain.Entities;
using InfraRepository.DbContext;

namespace InfraRepository.Repositories.AddCustomer;

public class AddCustomerRepository : IAddCustomerRepository
{
    private readonly IDbContext _dbContext;

    public AddCustomerRepository(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCustomer(Customer customer)
    {
        var query = "INSERT INTO customer(name, email, document)VALUES(@name, @email, @document)";

        var parameters = new DynamicParameters();
        parameters.Add("name", customer.Name, System.Data.DbType.String);
        parameters.Add("email", customer.Email, System.Data.DbType.String);
        parameters.Add("document", customer.Document, System.Data.DbType.String);

        using var connection = _dbContext.CreateConnection();
        
        connection.Execute(query, parameters);
    }
}