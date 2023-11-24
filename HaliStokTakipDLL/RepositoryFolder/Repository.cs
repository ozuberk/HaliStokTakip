using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipDLL.RepositoryFolder
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
   
        public Repository(DbContext dbContext)
        {
            Context = dbContext;
        }
        public IEnumerable<T> BulEnum(Expression<Func<T, bool>> sorgu)
        {
            return Context.Set<T>().Where(sorgu);
        }

        public IQueryable<T> BulQuery(Expression<Func<T, bool>> sorgu)
        {
            return Context.Set<T>().Where(sorgu);
        }

        public T Getir(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public int Guncelle(T entity)
        {
            return Context.SaveChanges();
        }

        public int Kaydet(T entity)
        {
            Context.Set<T>().Add(entity);
            return Context.SaveChanges();
        }

        public IEnumerable<T> Listele()
        {
            return Context.Set<T>().ToList();
        }

        public int Sil(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChanges();
        }
    }
}
