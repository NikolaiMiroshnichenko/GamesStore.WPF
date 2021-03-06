﻿using GamesStore.DAL.Entities;
using Services.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Services.Extensions
{
    public static class MappingExtensions
    {
        public static Game ToEntity(this GameDto dto)
        {
            Game game = new Game
            {
                Id = dto.Id,
                // Developer = dto.DeveloperDto.ToEntity(),
                Genre = dto.Genre,
                Description = dto.Description,
                Price = dto.Price,
                Title = dto.Title,
                ImageURL = dto.ImageURL
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
                Games = dto.Games.ToEntityCollection().ToList()
            };
            return developer;
        }
        public static GameDto ToDto(this Game entity)
        {
            GameDto gameDto = new GameDto
            {
                Id = entity.Id,
               // DeveloperDto = entity.Developer.ToDto(),
                Genre = entity.Genre,
                Description = entity.Description,
                Price = entity.Price,
                Title = entity.Title,
                ImageURL = entity.ImageURL
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
                Games = entity.Games.ToDtoCollection().ToList()
            };
            return developerDto;
        }
        public static IEnumerable <Game> ToEntityCollection(this IEnumerable<GameDto> dtos)
        {
            var entityCollection = new List <Game>();
            foreach (var item in dtos)
            {
                entityCollection.Add(item.ToEntity());
            }
            return entityCollection;
        }
        public static IEnumerable<Developer> ToEntityCollection(this IEnumerable<DeveloperDto> dtos)
        {
            var entityCollection = new List<Developer>();
            foreach (var item in dtos)
            {
                entityCollection.Add(item.ToEntity());
            }
            return entityCollection;
        }
        public static IEnumerable<GameDto> ToDtoCollection(this IEnumerable<Game> entities)
        {
            var dtoCollection = new List<GameDto>();
            foreach (var item in entities)
            {
                dtoCollection.Add(item.ToDto());
            }
            return dtoCollection;
        }
        public static IEnumerable<DeveloperDto> ToDtoCollection(this IEnumerable<Developer> entities)
        {
            var dtoCollection = new List<DeveloperDto>();
            foreach (var item in entities)
            {
                dtoCollection.Add(item.ToDto());
            }
            return dtoCollection;
        }
    }
}
