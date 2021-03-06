﻿using System;
using System.Collections.Generic;
using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using Services.Dto;
using Services.Interfaces;
using Services.Extensions;
using System.Linq;

namespace Services.Classes
{
    public class GameService : IGameService
    {
        private Repository<Game> _repository;
        public GameService(Repository<Game> repository)
        {
            _repository = repository;
        }

        public IEnumerable<GameDto> GetAll()
        {
            return _repository.GetAll().ToDtoCollection();
        }
        public IEnumerable<GameDto> GetByCondition(string name)
        {
            return _repository.GetAll().Where(x => x.Title.Equals(name)).ToDtoCollection();
        }
        public void Create(GameDto game)
        {
            _repository.Create(game.ToEntity());
            _repository.SaveChanges();
        }
        public void Update(GameDto game)
        {
            _repository.Update(game.ToEntity());
            _repository.SaveChanges();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }
    }
}
