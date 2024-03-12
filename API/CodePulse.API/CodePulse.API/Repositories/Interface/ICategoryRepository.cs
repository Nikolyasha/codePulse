using CodePulse.API.Models.Domains;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        Task<Category> GetCategoryById(int id);
        Task<List<Category>> GetCategoriesAll();
    }
}
