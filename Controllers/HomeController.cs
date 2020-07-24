using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroCliente.Models;

namespace CadastroCliente.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpPost]
        public ActionResult Index(CadastroCliente.Models.CadastroCliente model)
        {
            CadastroCliEntities db = new CadastroCliEntities();
            TB_CADASTRO_CLIENTE emp = new TB_CADASTRO_CLIENTE();
            emp.NM_CLIENTE = model.NM_CLIENTE;
            emp.CPF = model.CPF;
            emp.CEL_CLIENTE = model.CEL_CLIENTE;
            emp.EMAIL_CLIENTE = model.EMAIL_CLIENTE;
            emp.CEP = model.CEP;
            emp.CIDADE = model.CIDADE;
            emp.ENDERECO = model.ENDERECO;
            emp.BAIRRO = model.BAIRRO;
            emp.ESTADO = model.ESTADO;

            db.TB_CADASTRO_CLIENTE.Add(emp);
            db.SaveChanges();
            
            return View();
        }
        [HttpGet]
        public ActionResult actionResult()
        {
            ViewBag.Message = "";
            return View();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

    }
}
