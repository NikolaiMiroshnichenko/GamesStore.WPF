using System;
using System.Collections.Generic;
using System.Text;
using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using Services.Interfaces;

namespace Services.Classes
{
    public class GameService : IGameService
    {
        private Repository<Game> _repository;
        public GameService(Repository<Game> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Game> GetAll()
        {
            return _repository.GetAll();
        }
        public IEnumerable<Game> GetByCondition(Func<Game, bool> filter)
        {
            return _repository.GetByCondition(filter);
        }
        public void Create(Game game)
        {
            _repository.Create(game);
        }
        public void Update(Game game)
        {
            _repository.Update(game);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
