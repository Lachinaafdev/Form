using FormRegistro.Data;
using FormRegistro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FormRegistro.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;

        }



        public IActionResult Index()
        {

            IEnumerable<Usuario> listaUsuarios= _context.Usuarios;
            return View(listaUsuarios);
        }

        //HTTP Get create 
        public IActionResult Create()
        {
            return View();
        }


        //HTTP Post create 

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            return View();
        }



    }


}

     
