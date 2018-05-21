using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFAssessment
{
    public class BlogRepository<C, T> : IRepository<T> where T : BaseModel
                                                        where C : BlogDBContext
    {
        private BlogDBContext context = new BlogDBContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(int id)
        {
            var query = context.Set<T>().FirstOrDefault(c => c.Id == id);
           context.Set<T>().Remove(query);
            
            Save();
        }

        public void Edit(T entity)
        {
            Save();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = context.Set<T>().Where(predicate);
            return query;
            
        }

        public IQueryable<T> GetAll()
        {
            var query = context.Set<T>();
            return query;
        }

        public T GetSingle(int id)
        {
            var query = context.Set<T>().FirstOrDefault(c=>c.Id == id);
            return query;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
