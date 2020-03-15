using GamesStore.DAL.Entities;
using Services.Dto;
using System.Collections.Generic;

namespace Services.Extensions
{
    public static class MappingExtensions
    {
        public static Game ToEntity(this GameDto dto)
        {
            Game game = new Game
            {
                Id = dto.Id,
                Developer = dto.DeveloperDto.ToEntity(),
                Genre = dto.Genre,
                Description = dto.Genre,
                Price = dto.Price,
                Title = dto.Title
            };
            return game;
        }
        public static Developer ToEntity(this DeveloperDto dto)
        {
            Developer developer = new Developer
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                YearOfFoundation = dto.YearOfFoundation,
                Games = (List<Game>) dto.Games.ToDtoCollection()
            };
            return developer;
        }
        public static GameDto ToDto(this Game entity)
        {
            GameDto gameDto = new GameDto
            {
                Id = entity.Id,
                DeveloperDto = entity.Developer.ToDto(),
                Genre = entity.Genre,
                Description = entity.Genre,
                Price = entity.Price,
                Title = entity.Title
            };
            return gameDto;
        }
        public static DeveloperDto ToDto(this Developer entity)
        {
            DeveloperDto developerDto = new DeveloperDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                YearOfFoundation = entity.YearOfFoundation,
                Games = (List <GameDto>)entity.Games.ToDtoCollection()
            };
            return developerDto;
        }
        public static IEnumerable <Game> ToDtoCollection(this IEnumerable<GameDto> dtos)
        {
            var entityCollection = new List <Game>();
            foreach (var item in dtos)
            {
                item.ToEntity();
            }
            return entityCollection;
        }
        public static IEnumerable<Developer> ToDtoCollection(this IEnumerable<DeveloperDto> dtos)
        {
            var entityCollection = new List<Developer>();
            foreach (var item in dtos)
            {
                item.ToEntity();
            }
            return entityCollection;
        }
        public static IEnumerable<GameDto> ToDtoCollection(this IEnumerable<Game> entities)
        {
            var dtoCollection = new List<GameDto>();
            foreach (var item in entities)
            {
                item.ToDto();
            }
            return dtoCollection;
        }
        public static IEnumerable<DeveloperDto> ToDtoCollection(this IEnumerable<Developer> entities)
        {
            var dtoCollection = new List<DeveloperDto>();
            foreach (var item in entities)
            {
                item.ToDto();
            }
            return dtoCollection;
        }
    }
}
