using CodePulse.API.Data;
using CodePulse.API.Models.Domains;
using CodePulse.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext dbContext;

        public CategoryRepository(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        //add category
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
        //get category by id
        public async Task<Category> GetCategoryById(int id)
        {
            return await dbContext.Categories.FindAsync(id);
        }
        //get all categories
        public async Task<List<Category>> GetCategoriesAll()
        {
            return await dbContext.Categories.ToListAsync();
        }
    }
}
