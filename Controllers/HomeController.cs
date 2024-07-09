using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller {


        // localhost
        // localhost/Home
        // localhost/Home/index
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            // int saat = 11;
            // var selamlama = saat > 12 ? "İyi Günler":"Günaydın";

            // ViewBag.Selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            // ViewBag.Username = "Yahya Gümüş";

            ViewData["selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            // ViewData["UserName"] = "Yahya Gümüş";
            int UserCount= Repository.Users.Where(info=>info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo() {
                Id = 1,
                Location = "Adana",
                Date = new DateTime(2023, 07, 03 , 20, 0, 0),
                NumberOfPeople = UserCount

            };

            return View(meetingInfo);
        }

    }
}