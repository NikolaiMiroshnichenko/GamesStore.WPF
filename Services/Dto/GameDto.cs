using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DeveloperDto DeveloperDto { get; set; }
    }
}
