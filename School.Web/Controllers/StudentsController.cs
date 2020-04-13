namespace School.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using School.Web.Data;
    using School.Web.Data.Entities;
    using School.Web.Helpers;
    using School.Web.Models;
    using System.Threading.Tasks;

    public class StudentsController : Controller
    {
        private readonly DataContext dataContext;
        private readonly ICombosHelper combosHelper;
        private readonly IImageHelper imageHelper;

        public StudentsController(DataContext dataContext,
            ICombosHelper combosHelper,
            IImageHelper imageHelper)
        {
            this.dataContext = dataContext;
            this.combosHelper = combosHelper;
            this.imageHelper = imageHelper;
        }

        public async Task<IActionResult> Index()
        {
            return  View(await dataContext.Students.ToListAsync());
        }

        public IActionResult Create()
        {
            var model = new StudentViewModel
            {
                Genders = combosHelper.GetComboGenders()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel model)
        {
            if(ModelState.IsValid)
            {
                var student = new Student
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Enrollment = model.Enrollment,
                    BirthDate = model.BirthDate,
                    Gender =  await dataContext.Genders
                    .FirstOrDefaultAsync(m => m.Id == model.GenderId),
                    ImageUrl= await imageHelper
                    .UploadImageAsync(model.ImageFile,model.Enrollment, "Students")
                };
                dataContext.Students.Add(student);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
