using GomlaMarket.Data;
using GomlaMarket.IRepository;
using GomlaMarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GomlaMarket.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        readonly AppDbContext appDbContext;
        public CategoryRepository(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public List<Category> Get()
        {
            return appDbContext.Categories.AsNoTracking().ToList();
        }
        public Category GetById(int id) 
        {
            return appDbContext.Categories.FirstOrDefault( x => x.Id == id);
        }
        public void Create(Category category) 
        {
            appDbContext.Categories.Add(category);
            Save();
        }
        public void Update(Category category) 
        {
            //appDbContext.Categories.Update(category);
            //appDbContext.SaveChanges();

            Category cat = GetById(category.Id);
            cat.Name = category.Name;
            cat.DisplayOrder = category.DisplayOrder;
            appDbContext.SaveChanges();

            Save();
        }
        public void Delete(Category category) 
        {
            //appDbContext.Categories.Remove(category);
            //appDbContext.SaveChanges();

            Category cat = GetById(category.Id);
            appDbContext.Categories.Remove(cat);
            Save();
        }
        public void Save() 
        {
            appDbContext.SaveChanges();
        }
        
    }
}