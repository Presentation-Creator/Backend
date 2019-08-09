namespace PresentationCreatorWeb.Data.Models
{
    public class PresentationTag 
    {
        public int PresentationId { get; set; }
        public Presentation Presentation { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}