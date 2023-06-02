using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteCake.Storage;
using WebsiteCake.Storage.Entities;
namespace WebsiteCake.Logic.Categories
{
    public class CategoryManger : ICategoryManger
    {
        private readonly ConfectioneryContext _context;//положить значение только через конструктор или значение в эту строке прям сразу при объявление(тип менять походу нельзя) 
        
        

        public CategoryManger(ConfectioneryContext context)
        {
            _context = context;
        }

        public async Task Create(string name)
        {

            var category = new Сategory {Name = name };
            _context.Categories.Add(category);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category=_context.Categories.FirstOrDefault(c => c.Id == id);
            if(category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Сategory>> GetAll() => await _context.Categories.ToListAsync();


    }
}
