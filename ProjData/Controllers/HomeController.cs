using ProjData.Models.DadosTabela;
using ProjData.Models.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjData.Controllers
{
    public class HomeController : Controller
    {

        string dataAtt;
        public ActionResult Index()
        {
            clBuscaDesc busca = new clBuscaDesc();
            var listDesc = busca.buscaDesc();


            double total = 0;
            for (int i = 0; i < listDesc.Count; i++)
            {
                total = total + listDesc[i].Preco;
                dataAtt = listDesc[i].Datac;
            }

            Session["dataAtt"] = dataAtt;
            Session["TotalGasto"] = total;

            return View(listDesc);
        }

        clCadastraDesc clCadDesc = new clCadastraDesc();

        public ActionResult PageForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PageForm(Descricao descricao)
        {
            if (clCadDesc.insertCadastro(descricao) == false)
            {

                //TempData["error"] = "true";
               // TempData["StatusCadastro"] = "ERRO";
                ModelState.Clear();
                return View();
            }
            else
            {
                // TempData["StatusCadastro"] = "OK";
                ModelState.Clear();
                return RedirectToAction("Index", "Home");
            }

        }

    }
}