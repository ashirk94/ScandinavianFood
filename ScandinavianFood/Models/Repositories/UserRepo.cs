using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ScandinavianFood.Models
{
    public class UserRepository : IRepository<UserModel>
    {
        private readonly ForumPostContext context;

        public UserRepository(ForumPostContext context)
        {
            this.context = context;
        }

        public IEnumerable<UserModel> GetAll()
        {
            return context.Users;
        }

        public UserModel GetById(int id)
        {
            return context.Users.Find(id);
        }

        public void Insert(UserModel user)
        {
            context.Users.Add(user);
        }

        public void Delete(int id)
        {
            UserModel user = context.Users.Find(id);
            context.Users.Remove(user);
        }

        public void Update(UserModel user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
