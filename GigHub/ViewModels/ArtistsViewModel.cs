using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class ArtistsViewModel
    {
        public IEnumerable<ApplicationUser> FollowedArtists { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}