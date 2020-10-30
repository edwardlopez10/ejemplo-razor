using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploRazor.Models;
using EjemploRazor.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjemploRazor.Pages
{
    public class ArmasModel : PageModel
    {
        public IEnumerable<Arma> Armas { get; set; }
        public JsonFileArmaService ArmaService;

        public ArmasModel(JsonFileArmaService armaService)
        {
            ArmaService = armaService;
        }

        public void OnGet()
        {
            Armas = ArmaService.GetArmas();
        }
    }
}
