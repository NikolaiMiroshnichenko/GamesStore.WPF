﻿using System.Collections.Generic;

namespace GamesStore.DAL.Entities
{
    public class Developer: Entity
    {
        public Developer()
        {
            Games = new List<Game>();
        }
        public string Name { get; set; }
        public int YearOfFoundation { get; set; }
        public string Description { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
