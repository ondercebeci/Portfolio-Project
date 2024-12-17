using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            
            return View();

        }
    
    }
}
