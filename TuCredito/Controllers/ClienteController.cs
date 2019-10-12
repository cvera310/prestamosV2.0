using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuCredito.Models;

namespace TuCredito.Controllers
{
    public class ClienteController : Controller
    {
        private prestamoEntities db = new prestamoEntities();
        // GET: Cliente
        [Authorize]
        public ActionResult Index()
        {
            List<Cliente> listaClientes = db.Cliente.ToList();
            return View(listaClientes);
        }
    }
}