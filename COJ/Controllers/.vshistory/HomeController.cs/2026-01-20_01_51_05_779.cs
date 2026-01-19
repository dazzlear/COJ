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
                new("Silakbo", "Album", "2025", "~/img/silakbo.jpg", "https://www.youtube.com/watch?v=r5eisDLrYeE"),
                new("Sandali", "Single", "2025", "~/img/sandali.jpg", "https://www.youtube.com/watch?v=PGaUaT15Ei4"),
                new("Misteryoso", "Single", "2024", "~/img/misteryoso.jpg", "https://www.youtube.com/watch?v=Svm0vY91oN0&list=RDSvm0vY91oN0&start_radio=1"),
                new("Lahat Ng Bukas", "Single", "2024", "~/img/lahatngbukas.jpg", "https://www.youtube.com/watch?v=70IsaoX9Hdg&list=RD70IsaoX9Hdg&start_radio=1")
            }
        };

        return View(viewModel);
    }
}