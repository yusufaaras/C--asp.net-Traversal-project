using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels=new List<DestinationModel>();
            using(var c=new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City= x.City,
                    DayNight= x.DayNight,
                    Price= x.Price,
                    Capacity= x.Capacity,
                }).ToList();
            }
            return destinationModels;
        }
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","YeniExcel.xlsx");


           //application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

            

        }
        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1,1 ).Value = "Şehir";
                workSheet.Cell(1,2 ).Value = "Konaklama Süresi";
                workSheet.Cell(1,3 ).Value = "Fiyat";
                workSheet.Cell(1,4 ).Value = "Kapasite";

                int rowcount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowcount, 1).Value = item.City;
                    workSheet.Cell(rowcount, 2).Value = item.DayNight;
                    workSheet.Cell(rowcount, 3).Value = item.Price;
                    workSheet.Cell(rowcount, 4).Value = item.Capacity;
                    rowcount++;

                }
                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            } 
        }
    }
}
