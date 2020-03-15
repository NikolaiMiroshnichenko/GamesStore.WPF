using Services.Dto;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IDeveloperService
    {
        IEnumerable<DeveloperDto> GetAll();
        IEnumerable<DeveloperDto> GetByCondition(Func<DeveloperDto, bool> filter);
        void Create(DeveloperDto developer);
        void Update(DeveloperDto developer);
        void Delete(int id);
    }
}
