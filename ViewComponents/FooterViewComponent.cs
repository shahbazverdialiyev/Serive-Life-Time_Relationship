using Fiorello.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        readonly FiorelloDbContext _DbContext;
        public FooterViewComponent(FiorelloDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
