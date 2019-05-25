using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interface
{
    interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity Get(int Id);
        void Create(TEntity item);
        void Remove(int Id);
        void Update(TEntity item);
    }
}
