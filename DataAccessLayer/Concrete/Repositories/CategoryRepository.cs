using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    internal class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        DbSet<Category> _categories;
        public void Add(Category category)
        {
            _categories.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
            context.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            return _categories.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
