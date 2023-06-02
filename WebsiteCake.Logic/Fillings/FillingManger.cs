using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteCake.Logic.Fillings;
using WebsiteCake.Storage;
using WebsiteCake.Storage.Entities;

namespace WebsiteCake.Logic.Filling
{
    public class FillingManger : IFillingManger
    {

        private readonly ConfectioneryContext _context;//положить значение только через конструктор или значение в эту строке прям сразу при объявление(тип менять походу нельзя) 



        public FillingManger(ConfectioneryContext context)
        {
            _context = context;
        }

        public async Task Create(string name)
        {
            var filling=new WebsiteCake.Storage.Entities.Filling() { Name = name };
            _context.Fillings.Add(filling);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var filling =_context.Fillings.FirstOrDefault(x => x.Id == id); 
            if (filling != null)
            {
                _context.Fillings.Remove(filling);
                await _context.SaveChangesAsync();
            }

        }
       
        public async Task<IList<WebsiteCake.Storage.Entities.Filling>> GetAll()=> await _context.Fillings.ToListAsync();
    }
}
