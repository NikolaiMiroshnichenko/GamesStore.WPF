using System;
using System.Collections.Generic;
using System.Text;
using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;

namespace Services
{
    public class GameService 
    {
        private Repository<Entity> _repository;
        public GameService (Repository<Entity> repository)
        {
            _repository = repository;
        }

        public Entity GetById(int id)
        {
            return _repository.GetById(id);
        }

    }
}
