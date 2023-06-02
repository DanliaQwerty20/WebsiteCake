using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using WebsiteCake.Storage.Entities;

namespace WebsiteCake.Logic.Categories
{
    public interface ICategoryManger
    {
 
        Task<IList<Сategory>> GetAll();
        

        Task Create(string name);

        Task Delete(int id);
    }
}
