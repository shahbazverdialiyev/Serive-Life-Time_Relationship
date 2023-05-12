using Fiorello.DAL;
using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;

namespace Fiorello.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        readonly FiorelloDbContext _dbContext;

        public HeaderViewComponent(FiorelloDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
