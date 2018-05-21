using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFAssessment
{
    public interface IRepository<T> where T: BaseModel
    {
        T GetSingle(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Edit(T entity);
        void Delete(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Save();
    }
}
