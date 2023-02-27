using System.Collections.Generic;

namespace TestDotnetMsSql.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
