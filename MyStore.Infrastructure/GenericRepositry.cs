using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MyStore.Application;
using MyStore.Application.Contracts;
using MyStore.DbContext;
using MyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Infrastructure
{
    public class GenericRepositry<T ,TId> : IGenericRepository<T, TId> where T : BaseModel<TId>
    {
        MyStoreDbContext _MyContext;
        DbSet<T> _dbSet;


        public GenericRepositry(MyStoreDbContext context)
        {
            _MyContext = context;
           _dbSet=_MyContext.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _dbSet ;
        }

        public void Create(T catagory)
        {
           
            //_MyContext.Add(catagory);
            _dbSet.Add(catagory);
        }
        public T GetById ( TId PK)
        {
            //return  _dbSet.FirstOrDefault(e=>e.Id==Pk)
            return _dbSet.Find(PK);


        }

        public void Update(T catagory)
        {

            //_MyContext.Add(catagory);
            _dbSet.Update(catagory);
        }
        public void Delete(T catagory)
        {
            //_MyContext.catagories.Remove(catagory);
            _dbSet.Remove(catagory);

        }
        public int Save()
        {
            var ents = _MyContext.ChangeTracker.Entries();
            return _MyContext.SaveChanges();

        }

    }
}
