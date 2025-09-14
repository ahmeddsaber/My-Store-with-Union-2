using MyStore.DTO.CategoryDTO;
using MyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Application.Services
{
    public  interface ICategoryService
    {
        public List<CategoryDTO> GetAllCategories();
        public void CreateCategory(CreateCategoryDTOs catagory);
        public void DeleteCategory(Catagory catagory);

        public int Save();
    }
}
