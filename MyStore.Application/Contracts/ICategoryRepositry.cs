using MyStore.DTO.CategoryDTO;
using MyStore.Models;

namespace MyStore.Application.Interfaces
{
    public interface ICategoryRepositry
    { 
        public IQueryable<Catagory> GetAll();
        public void Create (Catagory Category);
        public void Delete(Catagory Category);

        public int Save();
    
    }
}
