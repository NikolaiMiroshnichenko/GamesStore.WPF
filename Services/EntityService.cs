using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class EntityService
    {
        private Repository<Entity> _repository;
        public EntityService(Repository<Entity> repository)
        {
            _repository = repository;
        }
        public Entity GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
