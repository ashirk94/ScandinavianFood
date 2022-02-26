using System.Collections.Generic;
using System.Threading.Tasks;
using ScandinavianFood.Models.DomainModels;

namespace ScandinavianFood.Models.Repositories
{
    public interface IPostRepository
    {
        Task<List<ForumPost>> GetAll();
        Task<ForumPost> GetById(int id);
        Task Insert(ForumPost obj);
        Task Update(ForumPost obj);
        Task Delete(int id);
        Task Save();
    }
}
