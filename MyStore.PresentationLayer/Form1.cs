using MyStore.Application;
using MyStore.Application.Interfaces;
using MyStore.Application.Mapper;
using MyStore.Application.Services;
using MyStore.DbContext;
using MyStore.DTO.CategoryDTO;
using MyStore.Infrastructure;
using MyStore.Models;

namespace MyStore.PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MapsterConfig.RegisterMapsterConfiguration();

            InitializeComponent();
            // Replace this line:
            // _catagoryList = _categoryService.GetAllCategories();

            // With this line:
            
            MyStoreDbContext myStoreDbContext = new MyStoreDbContext();
            ICategoryRepositry _categoryRepositry = new CategoryRepositry(myStoreDbContext);
           _categoryService = new CategeryService(_categoryRepositry);
        }
        ICategoryService _categoryService;
        List<CategoryDTO> _catagoryList;
        BindingSource _bindingSource;
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = _categoryService.Save();
            this.Text= r.ToString();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _catagoryList = _categoryService.GetAllCategories();
            _bindingSource = new BindingSource(_catagoryList, "");
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns[0].ReadOnly= true;
            //dataGridView1.RowValidated += (sender, e) =>
            //{
            //  if(  dataGridView1.Rows[e.RowIndex].DataBoundItem is Catagory NewCatagory)
            //    {
            //        _categoryService.CreateCategory(NewCatagory); ;
            //    }
            //};
 
            _bindingSource.AddingNew += (sender, e) =>
            {
                CreateCategoryDTOs Newcatagory = new CreateCategoryDTOs();
                e.NewObject = Newcatagory;
                _categoryService.CreateCategory(Newcatagory);

            };

            dataGridView1.UserDeletingRow += (sender, e) =>
            {
                if (e.Row.DataBoundItem is Catagory DeletedCategory)
                {
                    _categoryService.DeleteCategory(DeletedCategory);

                }

            };
            
        }
    }
}
