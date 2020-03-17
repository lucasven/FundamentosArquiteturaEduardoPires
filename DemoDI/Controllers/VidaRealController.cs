using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteService clienteService;

        public VidaRealController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        public void Index()
        {
            clienteService.AdicionarCliente(new Cliente());
            //return View();
        }
    }
}