using ScandinavianFood.Models.DomainModels;
using System.Linq;
using System.Threading.Tasks;

namespace ScandinavianFood.Models.Repositories
{
    public interface IPostRepository
    {
        public IQueryable<ForumPost> ForumPosts { get; }
        public Task<ForumPost> GetById(int id);
        public Task Insert(ForumPost obj);
        public Task Update(ForumPost obj);
        public Task Delete(int id);
        public Task Save();
    }
}
