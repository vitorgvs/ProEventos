using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento []
            {
                new Evento (){
                EventoId = 1,
                Tema = "Angular e .NET 5",
                local = "Belo Horizonte",
                Lote = "1 lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento (){
                EventoId = 2,
                Tema = "Angular e Suas Novidades",
                local = "São Paulo",
                Lote = "2 lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
            };
        public EventoController()
        {
        }  

        [HttpGet]
        public IEnumerable<Evento> get ()
        
        {
             
        return _evento;
            
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> get (int id)
        
        {
             
        return _evento.Where(Evento => Evento.EventoId == id);
            
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
