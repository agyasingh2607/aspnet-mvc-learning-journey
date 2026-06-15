using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface ITagRepository
    {
        //we have 5 methods in the AdminTagsController,
        //so we will create 5 methods in this interface as well,
        //and then we will implement this interface in the AdminTagsController

        Task<IEnumerable<Tag>> GetAllAsync();

        Task<Tag?> GetAsync(Guid id);

        Task<Tag> AddAync(Tag tag);

        Task<Tag?> UpdateAsync(Tag tag);

        Task<Tag?> DeleteAsync(Guid id);
    }
}
