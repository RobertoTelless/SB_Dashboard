using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationServices.Interfaces;
using EntitiesServices.Model;
using System.Globalization;
using EntitiesServices.WorkClasses;
using AutoMapper;
using SB_Dashboard_Presentation.ViewModels;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;
using System.Web.UI.WebControls;
using System.Runtime.Caching;
using Image = iTextSharp.text.Image;
using System.Text.RegularExpressions;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace SB_Dashboard_Presentation.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ICRAppService crApp;
        private readonly ICPAppService cpApp;
        private readonly ILPAppService lpApp;
        private readonly IPCAppService pcApp;

        private String msg;
        private Exception exception;
        //USUARIO objeto = new USUARIO();
        //USUARIO objetoAntes = new USUARIO();
        //List<USUARIO> listaMaster = new List<USUARIO>();
        String extensao;

        public DashboardController(ICRAppService crApps, ICPAppService cpApps, ILPAppService lpApps, IPCAppService pcApps)
        {
            crApp = crApps;
            cpApp = cpApps;
            lpApp = lpApps;
            pcApp = pcApps;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Voltar()
        {
            //if ((String)Session["Ativa"] == null)
            //{
            //    return RedirectToAction("Login", "ControleAcesso");
            //}
            return RedirectToAction("MontarTelaDashboard", "Dashboard");
        }

        public ActionResult VoltarBase()
        {
            //if ((String)Session["Ativa"] == null)
            //{
            //    return RedirectToAction("Login", "ControleAcesso");
            //}
            return RedirectToAction("MontarTelaDashboard", "Dashboard");
        }

        [HttpGet]
        public ActionResult MontarTelaDashboard()
        {
            List<SelectListItem> filtro = new List<SelectListItem>();
            filtro.Add(new SelectListItem() { Text = "Filtro 1", Value = "1" });
            filtro.Add(new SelectListItem() { Text = "Filtro 2", Value = "0" });
            ViewBag.Filtro = new SelectList(filtro, "Value", "Text");

            ModeloViewModel mod = new ModeloViewModel();
            mod.FiltroData = DateTime.Today.Date;    
            return View(mod);
        }

        [HttpPost]
        public ActionResult FiltrarTudoDashboard(ModeloViewModel item)
        {
            return RedirectToAction("MontarTelaDashboard");
        }

        public ActionResult VerResultados()
        {
            // Prepara view
            List<ModeloViewModel> lista = new List<ModeloViewModel>();
            for (int i = 8; i < 13; i++)
            {
                ModeloViewModel mod = new ModeloViewModel();
                mod.MesAno = i.ToString() + "/" + "2020";
                mod.Valor = 5426 * i;
                lista.Add(mod);
            }
            ViewBag.Lista = lista;

            List<ComentarioViewModel> listaCom = new List<ComentarioViewModel>();
            for (int i = 1; i < 4; i++)
            {
                ComentarioViewModel mod = new ComentarioViewModel();
                mod.Data = DateTime.Now;
                mod.Texto = "Texto do Comentário...";
                mod.Foto = "~/Imagens/Foto_base.jpg";
                mod.Nome = "Roberto Telles";
                listaCom.Add(mod);
            }
            ViewBag.Lista = lista;
            ViewBag.ListaComent = listaCom;

            List<AnexosViewModel> listaAnexo = new List<AnexosViewModel>();
            AnexosViewModel ane = new AnexosViewModel();
            ane.Arquivo = "~/Imagens/Imagem1.jpg";
            ane.Data = DateTime.Today.Date;
            ane.Tipo = 1;
            ane.Titulo = "Imagem Qualquer";
            listaAnexo.Add(ane);
            ane.Arquivo = "~/Imagens/PDF1.pdf";
            ane.Data = DateTime.Today.Date;
            ane.Tipo = 2;
            ane.Titulo = "PDF Qualquer";
            listaAnexo.Add(ane);
            ViewBag.ListaAnexo = listaAnexo;

            ModeloViewModel modelo = new ModeloViewModel();
            modelo.Observacao = "Observações quaisquer";
            return View(modelo);
        }

        public ActionResult VerResultadosSemGrafico()
        {
            // Prepara view
            List<ModeloViewModel> lista = new List<ModeloViewModel>();
            for (int i = 8; i < 13; i++)
            {
                ModeloViewModel mod = new ModeloViewModel();
                mod.MesAno = i.ToString() + "/" + "2020";
                mod.Valor = 5426 * i;
                lista.Add(mod);
            }
            ViewBag.Lista = lista;

            List<ComentarioViewModel> listaCom = new List<ComentarioViewModel>();
            for (int i = 1; i < 4; i++)
            {
                ComentarioViewModel mod = new ComentarioViewModel();
                mod.Data = DateTime.Now;
                mod.Texto = "Texto do Comentário...";
                mod.Foto = "~/Imagens/Foto_base.jpg";
                mod.Nome = "Roberto Telles";
                listaCom.Add(mod);
            }
            ViewBag.Lista = lista;
            ViewBag.ListaComent = listaCom;

            List<AnexosViewModel> listaAnexo = new List<AnexosViewModel>();
            AnexosViewModel ane = new AnexosViewModel();
            ane.Arquivo = "~/Imagens/Imagem1.jpg";
            ane.Data = DateTime.Today.Date;
            ane.Tipo = 1;
            ane.Titulo = "Imagem Qualquer";
            listaAnexo.Add(ane);
            ane.Arquivo = "~/Imagens/PDF1.pdf";
            ane.Data = DateTime.Today.Date;
            ane.Tipo = 2;
            ane.Titulo = "PDF Qualquer";
            listaAnexo.Add(ane);
            ViewBag.ListaAnexo = listaAnexo;

            ModeloViewModel modelo = new ModeloViewModel();
            modelo.Observacao = "Observações quaisquer";
            return View(modelo);
        }


        [HttpPost]
        public ActionResult IncluirComentario()
        {
            return RedirectToAction("VerResultados");
        }

        [HttpGet]
        public ActionResult MontarTelaDashboardReal()
        {
            // Carrega listas dos filtros
            List<vwContasAReceber> listaCR = crApp.GetAllItens();
            var listaCentroLucro = listaCR.Select(p => p.Centro_de_Lucro).Distinct().ToList();
            List<SelectListItem> listaCL = new List<SelectListItem>();
            foreach (var item in listaCentroLucro)
            {
                listaCL.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
            }
            ViewBag.CentroLucro = new SelectList(listaCL, "Value", "Text");

            List<vwContasAPagar> listaCP = cpApp.GetAllItens();
            var listaCentroCusto = listaCP.Select(p => p.Centro_de_Custos).Distinct().ToList();
            List<SelectListItem> listaCC= new List<SelectListItem>();
            foreach (var item in listaCentroCusto)
            {
                listaCC.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
            }
            ViewBag.CentroCusto = new SelectList(listaCC, "Value", "Text");

            List<vwLancamentosAPagar> listaLP = lpApp.GetAllItens();
            List<vwParcelamento> listaPC = pcApp.GetAllItens();

            // Carrega viewmodel
            DateTime inicio = Convert.ToDateTime("01/" + DateTime.Today.Date.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Today.Date.Year.ToString());
            ModeloViewModel mod = new ModeloViewModel();
            //mod.EmissaoInicio = inicio;
            //mod.EmissaoFinal = DateTime.Today.Date;
            //mod.VencimentoInicio = inicio;
            //mod.VencimentoFinal = DateTime.Today.Date;
            //mod.RecebimentoInicio = inicio;
            //mod.RecebimentoFinal = DateTime.Today.Date;
            //mod.PagamentoInicio = inicio;
            //mod.PagamentoFinal = DateTime.Today.Date;

            mod.EmissaoInicio = Convert.ToDateTime("01/05/2019");
            mod.EmissaoFinal = Convert.ToDateTime("30/05/2019");
            mod.VencimentoInicio = Convert.ToDateTime("01/05/2019");
            mod.VencimentoFinal = Convert.ToDateTime("30/05/2019");
            mod.RecebimentoInicio = Convert.ToDateTime("01/05/2019");
            mod.RecebimentoFinal = Convert.ToDateTime("30/05/2019");
            mod.PagamentoInicio = Convert.ToDateTime("01/05/2019");
            mod.PagamentoFinal = Convert.ToDateTime("30/05/2019");

            // Carrega Indicadores Diretos
            decimal execPositivo = Convert.ToDecimal(1004092.04);
            decimal execNegativo = Convert.ToDecimal(318449.39);
            decimal saldoBancario = Convert.ToDecimal(164604.20);

            ViewBag.ExecPositivo = execPositivo.ToString();
            ViewBag.ExecNegativo= execNegativo.ToString();
            ViewBag.SaldoBancario = saldoBancario.ToString();

            // Carrega Indicadores
            //decimal rec = listaCR.Where(p => p.Data_de_Recebimento.Value.Month == DateTime.Today.Date.Month & p.Data_de_Recebimento.Value.Year == DateTime.Today.Date.Year).Sum(p => p.Valor_Liquido);
            //decimal pag = listaCP.Where(p => p.Data_de_Pagamento.Value.Month == DateTime.Today.Date.Month & p.Data_de_Pagamento.Value.Year == DateTime.Today.Date.Year).Sum(p => p.Valor);
            //decimal lp = listaLP.Where(p => p.Data_de_Vencimento.Value.Month == DateTime.Today.Date.Month & p.Data_de_Vencimento.Value.Year == DateTime.Today.Date.Year).Sum(p => p.Valor);
            //decimal pc = listaPC.Sum(p => p.Valor_Bruto);

            decimal rec = listaCR.Where(p => p.Data_de_Recebimento.Value.Month == 5 & p.Data_de_Recebimento.Value.Year == 2019).Sum(p => p.Valor_Liquido);
            decimal pag = listaCP.Where(p => p.Data_de_Pagamento.Value.Month == 5 & p.Data_de_Pagamento.Value.Year == 2019).Sum(p => p.Valor);
            decimal lp = listaLP.Where(p => p.Data_de_Vencimento.Value.Month == 5 & p.Data_de_Vencimento.Value.Year == 2019).Sum(p => p.Valor);
            decimal pc = listaPC.Sum(p => p.Valor_Bruto);

            ViewBag.Rec = rec;
            ViewBag.Pag = pag;
            ViewBag.Lp = lp;
            ViewBag.Pc = pc;

            // Campos calculados
            Decimal result = (rec + execPositivo + pc) - (pag + execNegativo + lp);
            Decimal saldo = result + saldoBancario;
            ViewBag.Resultado = result;
            ViewBag.SaldoTotal = saldo;

            return View(mod);
        }


    }
}