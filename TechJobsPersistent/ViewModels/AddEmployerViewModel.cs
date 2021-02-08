﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Employer location is required.")]
        public string Location { get; set; }

        public AddEmployerViewModel(Employer employer)
        {

                Name = employer.Name;
                Location = employer.Location;
  
        }

        public AddEmployerViewModel() { }
    }
}
