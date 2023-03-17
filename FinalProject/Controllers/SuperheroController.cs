using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class SuperheroController : Controller
    {
        //Create, Details, Edit, Delete

        //Inject the database into the controller
        ApplicationDbContext _context;
        IWebHostEnvironment _environment;

        //Constructor
        public SuperheroController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }//end of Constructor

        public IActionResult Index()
        {
            //Default will show a list of active heroes
            IEnumerable<Superhero> superheroes = _context.Superheroes.Where(s => s.SuperheroStatusId == 1);
            return View(superheroes);
        }//End of View

        [HttpGet]
        public IActionResult Create()
        {
            //Make a selectlit for the list of possible statuses
            IEnumerable<SelectListItem> statusList = _context.SuperheroStatuses.Select(s => new SelectListItem
            {
                Text = s.StatusTitle,
                Value = s.Id.ToString()
            });
            //Make a Viewbag with the list
            ViewBag.statusesListVB = statusList;

            return View();
        }//end of HttpGet Create()

        [HttpPost]
        public IActionResult Create(Superhero superhero)
        {
            throw new NotImplementedException();
        }//end of HttpPost Create()

    }//End of class
}//End of namespace
