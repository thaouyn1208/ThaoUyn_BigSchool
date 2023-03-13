using System.Linq;
using System.Web.Mvc;
using TranNguyenThaouyen_2011068936.Models;
using TranNguyenThaoUyen_2011068936.ViewModels;

namespace TranNguyenThaouyen_2011068936.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CoursesController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public CoursesController ()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}