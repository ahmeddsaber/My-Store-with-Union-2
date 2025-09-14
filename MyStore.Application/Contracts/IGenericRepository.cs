using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Application.Contracts
{
    public interface IGenericRepository<T, TId>
    {
        public IQueryable<T> GetAll();
        public T GetById(TId PK);
        public void Create(T catagory);
        public void Update(T catagory);
        public void Delete(T catagory);
        public int Save();
    }
}

