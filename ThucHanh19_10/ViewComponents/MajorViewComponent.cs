
using Microsoft.AspNetCore.Mvc;
using ThucHanh19_10.Data;

namespace ThucHanh19_10.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        private readonly SchoolContext db;

        public MajorViewComponent(SchoolContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            var majors = db.Majors.ToList();
            return View("RenderMajor", majors);
        }
    }
}
