using System.Collections.Generic;

namespace PresentationCreatorWeb.Data.Models
{
    public class Feature 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserFeature> UserFeatures { get; set; }
    }
}