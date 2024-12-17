using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioMenager portfolioMenager = new PortfolioMenager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolioMenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
            if(results.IsValid)
            {
                portfolioMenager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioMenager.GetByID(id);
            portfolioMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioMenager.GetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioMenager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
