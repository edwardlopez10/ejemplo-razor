using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjemploRazor.Pages.Forms
{
    public class RegistroDeArmasModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }

        [BindProperty]
        public string Img { get; set; }

        public string Mensaje { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Mensaje = "Se registro: " + Nombre;
            return Page();
        }
    }
}
