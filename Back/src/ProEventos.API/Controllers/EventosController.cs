﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
            
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }  

        [HttpGet]
        public IEnumerable<Evento> get ()
        
        {
             
        return _context.Eventos;
            
        }
        [HttpGet("{id}")]
        public Evento get (int id)
        
        {
             
        return _context.Eventos.FirstOrDefault(Evento => Evento.EventoId == id);
            
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
