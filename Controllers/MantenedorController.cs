using Microsoft.AspNetCore.Mvc;

using CRUDCORE.Datos;
using CRUDCORE.Models;


namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {



        ContactoDatos _ContactoDatos = new ContactoDatos();



        public IActionResult listar() //mostrara una lista de contactos
        {
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }




        public IActionResult guardar() //devolver vista, formulario html
        {
            return View();
        }





        [HttpPost]
        public IActionResult guardar(ContactoModel oContacto) //recibir un objeto y guardarlo en base de datos
        {
            
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _ContactoDatos.guardar(oContacto);
            if (respuesta)
            {
                return RedirectToAction("listar");
            }
            else
            {
                return View();
            }
        }




        public IActionResult editar(int idContacto) //devolver vista, formulario html
        {
            var oContacto = _ContactoDatos.Obtener(idContacto);
            return View(oContacto);
        }




        [HttpPost]
        public IActionResult editar(ContactoModel oContacto) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _ContactoDatos.editar(oContacto);
            if (respuesta)
            {
                return RedirectToAction("listar");
            }
            else
            {
                return View();
            }
        }




        public IActionResult eliminar(int idContacto) //devolver vista, formulario html
        {
            var oContacto = _ContactoDatos.Obtener(idContacto);
            return View(oContacto);
        }




        [HttpPost]
        public IActionResult eliminar(ContactoModel oContacto)
        {
            
            var respuesta = _ContactoDatos.eliminar(oContacto.idContacto);
            if (respuesta)
            {
                return RedirectToAction("listar");
            }
            else
            {
                return View();
            }
        }
    }
}
