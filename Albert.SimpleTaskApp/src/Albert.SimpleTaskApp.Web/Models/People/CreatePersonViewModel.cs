﻿using Albert.SimpleTaskApp.People;
using Albert.SimpleTaskApp.Web.Utils;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albert.SimpleTaskApp.Web.Models.People
{
    public class CreatePersonViewModel
    {
        public List<SelectListItem> Genders { get; set; }

        public CreatePersonViewModel()
        {
            Genders = InitGender();
        }

        private List<SelectListItem> InitGender()
        {
            return EnumHelper.GetSelectList<Genter>();
        }
    }
}
