using System;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;

namespace ScandinavianFood.Models.Repositories
{
    public class FakeUserRepo : IRepository<UserModel>
    {
        private readonly List<UserModel> users = new List<UserModel>();

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel GetById(int id)
        {
            UserModel user = users.Find(p => p.Id == id);
            return user;
        }

        public void Insert(UserModel user)
        {
            user.Id = users.Count;
            users.Add(user);
        }

        public void Delete(int id)
        {
            UserModel user = users.Find(p => p.Id == id);
            users.Remove(user);
        }

        public void Update(UserModel user)
        {
            int id = user.Id;
            user = users.Find(p => p.Id == id);
        }

        public void Save()
        {
            return;
        }
    }
}
