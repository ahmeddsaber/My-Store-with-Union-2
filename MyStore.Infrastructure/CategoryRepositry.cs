using MyStore.Application;
using MyStore.Application.Interfaces;
using MyStore.DbContext;
using MyStore.DTO.CategoryDTO;
using MyStore.Models;

namespace MyStore.Infrastructure
{
    public class CategoryRepositry : ICategoryRepositry
    {
        MyStoreDbContext _MyContext = new();
        public CategoryRepositry(MyStoreDbContext context)
        {
            _MyContext = context;
        }
        public IQueryable<Catagory> GetAll()
        {
            return _MyContext.catagories;
        }
     
        public void Delete(Catagory catagory)
        {
            _MyContext.catagories.Remove(catagory);

        }
        public int Save()
        {
            var ents = _MyContext.ChangeTracker.Entries();
            return  _MyContext.SaveChanges();

        }

        public void Create(Catagory catagory)
        {

            _MyContext.catagories.Add(catagory);
        }
    }
}
