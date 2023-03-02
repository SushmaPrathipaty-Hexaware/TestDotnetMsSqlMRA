using TestDotnetMsSql.Entities.Entities;


namespace TestDotnetMsSql.Data.Interfaces
{
    public interface IEmployeeRepository : IGetById<Employee>, IGetAll<Employee>, ISave<Employee>, IUpdate<Employee>, IDelete<int>
    {
    }
}
