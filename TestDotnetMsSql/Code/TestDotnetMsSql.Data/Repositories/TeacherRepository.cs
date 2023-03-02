using TestDotnetMsSql.Data.Interfaces;
using TestDotnetMsSql.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace TestDotnetMsSql.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;        

        public TeacherRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Teacher> GetAll()
        {            
            return _context.Teacher.ToList();
        }

        public bool Save(Teacher entity)
        {
            if (entity == null)
            return false;
            _context.Teacher.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Teacher Update(Teacher entity)
        {     
             _context.Teacher.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Teacher.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Teacher GetById(int id)
        {
            return _context.Teacher.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
