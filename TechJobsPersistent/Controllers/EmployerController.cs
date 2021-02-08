﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {

        private JobDbContext context;
        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers
                .ToList();
            return View(employers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            Employer employer = new Employer();
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel(employer);
            return View(addEmployerViewModel);
        }

        [HttpPost, Route("/Add")]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {

            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };

                context.Employers.Add(newEmployer);
                context.SaveChanges();

                return Redirect("/Employer");
            }

            return View(addEmployerViewModel);
        }

        public IActionResult About(int id)
        {
            Employer theEmployer = context.Employers
                .Single(x => x.Id == id);

            AddEmployerViewModel viewModel = new AddEmployerViewModel(theEmployer);
            return View(viewModel);
        }
    }
}
