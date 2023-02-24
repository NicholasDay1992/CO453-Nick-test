using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsoleAppProject.App01;

namespace Web2.Pages
{
	public class DistanceModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; }

        public void OnGet()
        {

        }
    }
}
