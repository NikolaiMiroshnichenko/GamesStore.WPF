using Services.Dto;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IGameService
    {
        IEnumerable<GameDto> GetAll();
        IEnumerable<GameDto> GetByCondition(string name);
        void Create(GameDto game);
        void Update(GameDto game);
        void Delete(int id);
    }
}
