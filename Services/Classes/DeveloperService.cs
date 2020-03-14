using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Classes
{
    public class DeveloperService : IDeveloperService
    {
        private Repository<Developer> _repository;
        public DeveloperService(Repository<Developer> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Developer> GetAll()
        {
            return _repository.GetAll();
        }
        public IEnumerable<Developer> GetByCondition(Func<Developer, bool> filter)
        {
            return _repository.GetByCondition(filter);
        }
        public void Create(Developer developer)
        {
            _repository.Create(developer);

        }
        public void Update(Developer developer)
        {
            _repository.Update(developer);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
