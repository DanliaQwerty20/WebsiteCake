using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteCake.Storage.Entities;


namespace WebsiteCake.Logic.Fillings
{
    public interface IFillingManger
    {
        Task<IList<WebsiteCake.Storage.Entities.Filling>> GetAll();
        Task Create(string name);

        Task Delete(int id);

    }
}
