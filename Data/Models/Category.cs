using System.Collections.Generic;

namespace PresentationCreatorWeb.Data.Models
{
    public class Category 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Presentation> Presentations { get; set; }
    }
}