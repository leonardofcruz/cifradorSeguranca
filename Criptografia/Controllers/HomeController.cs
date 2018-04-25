using Criptografia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Criptografia.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Cripto - Aplicativo de (des)criptografia.";

            return View();
        }


        // GET: Home/Criptografia
        public ActionResult Criptografia()
        {
            Cifra objetoCifra = new Cifra();

            ViewBag.cifra = 0;
            ViewBag.operacao = 0;


            return View(objetoCifra);
        }


        // POST: Home/Criptografia
        [HttpPost]
        public ActionResult Criptografia(string textoOriginal, string chave, int cifraCripto, int operacao)
        {
            Cifra objetoCifra = new Cifra();
            objetoCifra.textoOriginal = textoOriginal;
            objetoCifra.chave = chave;
            objetoCifra.cifra = cifraCripto;
            objetoCifra.operacao = operacao;
            try
            {
                if (objetoCifra.Validado())
                {
                    ViewBag.cifra = cifraCripto;
                    ViewBag.operacao = operacao;
                    ViewBag.textoCifrado = objetoCifra.textoModificado;

                }
                return View(objetoCifra);
            }
            catch (Exception e)
            {
                ViewBag.textoErro = e.Message;
                ViewBag.cifra = cifraCripto;
                ViewBag.operacao = operacao;
                objetoCifra.textoModificado = "";
                return View(objetoCifra);
            }
        }


    }
}
