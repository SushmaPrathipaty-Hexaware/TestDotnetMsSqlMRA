using TestDotnetMsSql.Entities.Entities;


namespace TestDotnetMsSql.Data.Interfaces
{
    public interface ITeacherRepository : IGetById<Teacher>, IGetAll<Teacher>, ISave<Teacher>, IUpdate<Teacher>, IDelete<int>
    {
    }
}
