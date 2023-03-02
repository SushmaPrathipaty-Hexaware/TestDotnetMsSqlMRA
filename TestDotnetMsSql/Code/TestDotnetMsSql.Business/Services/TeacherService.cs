using TestDotnetMsSql.Business.Interfaces;
using TestDotnetMsSql.Data.Interfaces;
using TestDotnetMsSql.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDotnetMsSql.Business.Services
{
    public class TeacherService : ITeacherService
    {
        ITeacherRepository _TeacherRepository;

        public TeacherService(ITeacherRepository TeacherRepository)
        {
           this._TeacherRepository = TeacherRepository;
        }
        public IEnumerable<Teacher> GetAll()
        {
            return _TeacherRepository.GetAll();
        }

        public Teacher Save(Teacher Teacher)
        {
            _TeacherRepository.Save(Teacher);
            return Teacher;
        }

        public Teacher Update(Teacher Teacher)
        {
            return _TeacherRepository.Update( Teacher);
        }

        public bool Delete(int id)
        {
            return _TeacherRepository.Delete(id);
        }
        public Teacher GetById(int id)
        {
            return _TeacherRepository.GetById(id);
        }
    }
}
