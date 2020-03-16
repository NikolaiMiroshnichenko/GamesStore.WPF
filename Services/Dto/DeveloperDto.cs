using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class DeveloperDto
    {
        public DeveloperDto()
        {
            Games = new List<GameDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfFoundation { get; set; }
        public string Description { get; set; }
        public ICollection<GameDto> Games { get; set; }
    }
}
