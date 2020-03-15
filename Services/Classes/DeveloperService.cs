using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using Services.Dto;
using Services.Extensions;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Classes
{
    public class DeveloperService : IDeveloperService
    {
        private Repository<Developer> _repository;
        public DeveloperService(Repository<Developer> repository)
        {
            _repository = repository;
        }

        public IEnumerable<DeveloperDto> GetAll()
        {
            return _repository.GetAll().ToDtoCollection();
        }
        public IEnumerable<DeveloperDto> GetByCondition(Func<DeveloperDto, bool> filter)
        {
            return _repository.GetByCondition(filter);
        }
        public void Create(DeveloperDto developer)
        {
            _repository.Create(developer.ToEntity());
            _repository.SaveChanges();
        }
        public void Update(DeveloperDto developer)
        {
            _repository.Update(developer.ToEntity());
            _repository.SaveChanges();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }
    }
}
