using ClassLibrary1.Context;
using ClassLibrary1.Interface;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class CompanyRepository<T>:IRepository<T> where T:BaseModel
    {
        WebDbContext _context;
        DbSet<T> _entities;

        public CompanyRepository()
        {
            _context = new WebDbContext();
            _entities = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T Get(int Id)
        {
            return _entities.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Create(T item)
        {
            _entities.Add(item);
            _context.SaveChanges(); 
        }

        public void Remove(int Id)
        {
            T toRemove = _entities.Find(Id);
            _entities.Remove(toRemove);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        ~CompanyRepository()
        {
            _context.Dispose();
        }
    }
}
