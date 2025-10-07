using GomlaMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomlaMarket.IRepository
{
    public interface ICategoryRepository
    {
        public List<Category> Get();
        public Category GetById(int id);
        public void Create(Category category);
        public void Update(Category category);
        public void Delete(Category category);
    }
}
