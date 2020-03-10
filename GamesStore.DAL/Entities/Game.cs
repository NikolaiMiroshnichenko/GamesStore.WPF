using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GamesStore.DAL.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Developer Developer { get; set; }
        public string Genre { get; set; }
        public string Discription { get; set; }
    }
}
