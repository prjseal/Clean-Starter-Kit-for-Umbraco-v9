using Clean.Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Core.Components
{
    [ViewComponent(Name = "Pagination")]
    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int totalItems, string url, 
            int pageNumber = 1, int pageSize = 10, int pageNumbersEitherSide = 1)
        {
            var model = new PaginationViewModel()
            {
                TotalItems = totalItems,
                Url = url,
                PageNumber = pageNumber,
                PageSize = pageSize,
                PageNumbersEitherSide = pageNumbersEitherSide
            };
            return View(model);
        }
    }
}
