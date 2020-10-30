using EjemploRazor.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EjemploRazor.services
{
    public class JsonFileArmaService
    {
        public IWebHostEnvironment WenHostEnvironment { get; }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WenHostEnvironment.WebRootPath, "data", "armas.json");
            }
        }

        public JsonFileArmaService(IWebHostEnvironment WebHostEnvironment)
        {
            WenHostEnvironment = WebHostEnvironment;
        }

        public IEnumerable<Arma> GetArmas()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Arma[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }
    }
}
