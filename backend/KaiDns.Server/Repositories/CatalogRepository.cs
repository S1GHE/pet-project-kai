using KaiDns.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace KaiDns.Server.Repositories
{
    public class CatalogRepository : IRepository<Catalog>
   
    {
        Db4660Context db;
        public CatalogRepository()
        {
            db = new Db4660Context();
        }
        public IEnumerable<Catalog> GetAll()
        {
            return db.Catalogs.ToList();
        }

        public Catalog Get(int id)
        {
            return db.Catalogs.Find(id);
        }

        public void Create(Catalog item)
        {
            db.Catalogs.Add(item);
        }

        public void Update(Catalog item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Catalog user = db.Catalogs.Find(id);
            if (user != null)
                db.Catalogs.Remove(user);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
