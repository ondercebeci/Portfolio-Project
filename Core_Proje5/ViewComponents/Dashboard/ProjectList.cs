using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Dashboard
{
    public class ProjectList: ViewComponent
    {
        PortfolioMenager portfolioMenager = new PortfolioMenager(new EfPortfolioDal());
        public IViewComponentResult Invoke() 
        {
            var values = portfolioMenager.TGetList();
            return View(values);
        
        }
    }
}
