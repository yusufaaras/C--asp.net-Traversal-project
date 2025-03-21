using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination_yerler destination)
        {
            destination.status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult GetById(int DestinationId)
        {
            var values=_destinationService.TGetById(DestinationId);
            var jsonvalues=JsonConvert.SerializeObject(values);
            return Json(jsonvalues);
        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values); 
            return NoContent();
        }
        public IActionResult UpdateCity(Destination_yerler destination)
        {
            var values = _destinationService.TGetById(destination.DestinationId);
            destination.status = values.status;
            destination.Price = values.Price;
            destination.Image = values.Image;
            destination.Description = values.Description;
            destination.Capacity = values.Capacity;
            destination.CoverImage = values.CoverImage;
            destination.Details1 = values.Details1;
            destination.Details2 = values.Details2;
            destination.Image2 = values.Image2;
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }
    }
}
