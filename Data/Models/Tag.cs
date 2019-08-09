using System.Collections.Generic;

namespace PresentationCreatorWeb.Data.Models
{
    public class Tag 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PresentationTag> PresentationTags { get; set; }
    }
}