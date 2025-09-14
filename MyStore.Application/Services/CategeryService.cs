using Mapster;
using MyStore.Application.Interfaces;
using MyStore.DTO.CategoryDTO;
using MyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Application.Services
{
    public class CategeryService : ICategoryService
    {
        ICategoryRepositry _categoryRepositry;


        public CategeryService(ICategoryRepositry categoryRepositry)
        {
           _categoryRepositry = categoryRepositry;
        }
        public List<CategoryDTO> GetAllCategories()
        {
            //IQueryable<Catagory> AllCategoryQuery=  _categoryRepositry.GetAll();
            // var AllCategory = AllCategoryQuery.Where(c => c.Products.Count > 0).Select(p => 
            // new CategoryDTO
            // {
            //     CatId = p.Id,
            //     CatName = p.Name,
            //     CatDisc= p.Description,
            // }).ToList();
            IQueryable<Catagory> AllCategoryQuery = _categoryRepositry.GetAll();
            var AllCategory = AllCategoryQuery.Where(c => c.Products.Count > 0).ToList().Adapt <List<CategoryDTO>>();
            return AllCategory;
        }




        public int Save()
        {
            return _categoryRepositry.Save();
        }

        public void DeleteCategory(Catagory catagory)
        {
           _categoryRepositry.Delete(catagory);
        }

      

  

     

        public void CreateCategory(CreateCategoryDTOs catagory)
        {
            //Catagory NewCatagery = new Catagory()
            //{
            //    Name = catagory.Name,
            //    Description = catagory.Description
            //};
            Catagory NewCatagery = catagory.Adapt<Catagory>();
         
            _categoryRepositry.Create(NewCatagery);
        }
    }
    }

