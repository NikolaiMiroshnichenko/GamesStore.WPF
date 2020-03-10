using System;
using System.Collections.Generic;
using System.Text;

namespace GamesStore.DAL.Entities
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfFoundation { get; set; }
        public string Discription { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
