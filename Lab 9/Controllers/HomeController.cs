using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab9_ori00.Models;


namespace lab9_ori00.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    // public IActionResult Index()
    // {
    //     return View();
    // }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
    // public IActionResult ReceivedDataByRequest()
    // {
    //         string student = Request.Form["student"];
    //         string year = Request.Form["year"];
    //         string course_1 = Request.Form["course_1"];
    //         string course_2 = Request.Form["course_2"];
    //         string course_3 = Request.Form["course_3"];

    //         return View("ReceivedDataByRequest", $"Name: {student} | Year:{year} | Course Grades: {course_1} | {course_2} | {course_3}");
    // }

    // GET: Home
    public ActionResult Index()
    {
        return View();
    }
 
    [HttpPost]
    public ActionResult Index(StudentSummary student)
    {
        string StudentName = student.StudentName;
        string year = student.Year;
        string course_1 = student.Course_1;
        string course_2 = student.Course_2;
        string course_3 = student.Course_3;
        string GPA = student.GPA;
 
        return View("Index");
    }
    [HttpPost] 
        public ActionResult form1(StudentSummary student)
        {
            ViewBag.StudentName = student.StudentName;
            ViewBag.Year = student.Year;
            ViewBag.Course_1 = student.Course_1;
 
            return View();
        }
}
