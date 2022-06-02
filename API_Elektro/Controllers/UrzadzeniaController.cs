using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API_Elektro.Models;

namespace API_Elektro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrzadzeniaController : ControllerBase
    {
        private readonly UrzadzeniaService _urzadzeniaService;

        public UrzadzeniaController(UrzadzeniaService _urzadzeniaService)
        {
            this._urzadzeniaService = _urzadzeniaService;
        }

        [HttpPost]
        public IEnumerable<Urzadzenie> Dodaj([FromBody] Urzadzenie u)
        {
            return _urzadzeniaService.Dodaj(u);
        }

        [HttpGet]
        public IEnumerable<Urzadzenie> Pobierz()
        {
            return _urzadzeniaService.Pobierz();
        }

        [HttpDelete]
        public IEnumerable<Urzadzenie> Wyczysc()
        {
            return _urzadzeniaService.Wyczysc();
        }

        [HttpDelete("{nazwa}")]
        public IEnumerable<Urzadzenie> UsunUrzadzenie(string nazwa)
        {
            return _urzadzeniaService.Usun(nazwa);
        }

        [HttpPut]
        public IEnumerable<Urzadzenie> UstawCene([FromBody] double cena)
        {
            return _urzadzeniaService.UstawCene(cena);
        }
    }
}
