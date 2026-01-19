using Microsoft.AspNetCore.Mvc;
using COJ.Models;

namespace COJ.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            Members = new List<BandMember>
            {
            new("Gian Bernardino", "Lead Vocals", "~/img/gian.jpg"),
            new("Raphaell Ridao", "Lead Vocals", "~/img/raphaell.jpg"),
            new("Gabriel Fernandez", "Lead Guitar", "~/img/gabriel.jpg"),
            new("CJ Fernandez", "Rhythm Guitar", "~/img/cj.jpg"),
            new("Xen Gareza", "Keyboardist", "~/img/xen.jpg")
            },
            Discography = new List<Album>
            {
                new("Silakbo", "Album", "2025", "~/img/silakbo.jpg"),
                new("Sandali", "Single", "2023", "https://images.unsplash.com/photo-1493225255756-d9584f8606e9?q=80&w=500"),
                new("Tingin", "Single (feat. Janine Teñoso)", "2023", "https://images.unsplash.com/photo-1514525253361-bee8718a300a?q=80&w=500"),
                new("Mananatili", "Single", "2022", "https://images.unsplash.com/photo-1459749411177-042180ce673c?q=80&w=500")
            },
            UpcomingShows = new List<Show>
            {
                new("Oct 15, 2023", "New Frontier Theater", "Quezon City", "Sold Out"),
                new("Oct 28, 2023", "Cebu IT Park", "Cebu City", "Tickets Available"),
                new("Nov 12, 2023", "SMX Convention Center", "Davao", "Selling Fast")
            }
        };

        return View(viewModel);
    }
}