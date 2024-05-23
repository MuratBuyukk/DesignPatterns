using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Germany",
                CityName = "Berlin",
                VisitPlaceName = "Brandenburg Door",
            });

            visitRouteMover.AddVisitRoute(new VisitRoute
            {

                CountryName = "France",
                CityName = "Paris",
                VisitPlaceName = "Eiffel Tower"
            });

            visitRouteMover.AddVisitRoute(new VisitRoute
            {

                CountryName = "Italy",
                CityName = "Venice",
                VisitPlaceName = "Rialto Bridge"
            });

            visitRouteMover.AddVisitRoute(new VisitRoute
            {

                CountryName = "Italy",
                CityName = "Rome",
                VisitPlaceName = "Colosseum",
            });

            visitRouteMover.AddVisitRoute(new VisitRoute
            {

                CountryName = "The Czech Republic",
                CityName = "Prag",
                VisitPlaceName = "St. Nicholas Church",
            });

            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName + " " + iterator.CurrentItem.CityName + " " + iterator.CurrentItem.VisitPlaceName);
            }
            ViewBag.v = strings;
            return View();
        }
    }
}
