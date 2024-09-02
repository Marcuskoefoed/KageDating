using System.Diagnostics;

namespace KageDating.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string AboutMe { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public bool Smoker { get; set; }
        public int Height {  get; set; }
        public int Weight { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
