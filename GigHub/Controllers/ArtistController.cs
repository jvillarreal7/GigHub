using GigHub.Core.ViewModels;
using GigHub.Persistence;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Following()
        {
            var userId = User.Identity.GetUserId();
            var artists = _context.Users
                .Where(a => a.Followers.Any(f => f.FollowerId == userId));


            var viewModel = new ArtistsViewModel()
            {
                FollowedArtists = artists,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Artists I follow"
            };

            return View(viewModel);
        }
    }
}