using GamesStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IDeveloperService
    {
        IEnumerable<Developer> GetAll();
        IEnumerable<Developer> GetByCondition(Func<Developer, bool> filter);
        void Create(Developer developer);
        void Update(Developer developer);
        void Delete(int id);
    }
}
