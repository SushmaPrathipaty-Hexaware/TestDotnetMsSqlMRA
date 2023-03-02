using TestDotnetMsSql.Data.Interfaces;
using TestDotnetMsSql.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace TestDotnetMsSql.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;        

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {            
            return _context.Employee.ToList();
        }

        public bool Save(Employee entity)
        {
            if (entity == null)
            return false;
            _context.Employee.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Employee Update(Employee entity)
        {     
             _context.Employee.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Employee.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Employee GetById(int id)
        {
            return _context.Employee.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
