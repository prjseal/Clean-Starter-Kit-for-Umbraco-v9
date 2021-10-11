using Clean.Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Core.Components
{
    [ViewComponent(Name = "Contact")]
    public class ContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ContactViewModel model)
        {
            return View(model);
        }
    }
}
