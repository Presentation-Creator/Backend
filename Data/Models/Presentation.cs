using System.Collections.Generic;

namespace PresentationCreatorWeb.Data.Models
{
    public class Presentation 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorUserId { get; set; }
        public int CategoryId { get; set; }
        public ICollection<PresentationTag> PresentationTags { get; set; }
        public User CreatorUser { get; set; }
        public Category Category { get; set; }
    }
}