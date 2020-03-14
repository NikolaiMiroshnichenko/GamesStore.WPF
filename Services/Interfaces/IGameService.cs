using GamesStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IGameService
    {
        IEnumerable<Game> GetAll();
        IEnumerable<Game> GetByCondition(Func<Game, bool> filter);
        void Create(Game game);
        void Update(Game game);
        void Delete(int id);
    }
}
