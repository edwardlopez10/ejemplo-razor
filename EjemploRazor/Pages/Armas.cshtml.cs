using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjemploRazor.Pages
{
    public class ArmasModel : PageModel
    {
        List<Arma> Armas
        {
            get
            {
                List<Arma> ListaFalsaDeArmas = new List<Arma>();
                for (int i = 0; i < 10; i++)
                {
                    Arma ArmaFalsa = new Arma();
                    ArmaFalsa.Id = i;
                    ArmaFalsa.Nombre = "Arma " + i;
                    ListaFalsaDeArmas.Add(ArmaFalsa);
                }
                return ListaFalsaDeArmas;
            }
        }
        public void OnGet()
        {
        }
    }
}
