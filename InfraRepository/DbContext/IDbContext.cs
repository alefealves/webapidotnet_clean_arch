using System.Data;

namespace InfraRepository.DbContext;

public interface IDbContext
{
    public IDbConnection CreateConnection();
}