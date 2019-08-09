namespace PresentationCreatorWeb.Data.Models
{
    public class UserFeature 
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public double PrecentValue { get; set; }
    }
}