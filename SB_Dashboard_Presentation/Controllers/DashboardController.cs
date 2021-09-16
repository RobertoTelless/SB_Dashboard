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
        private readonly IEPAppService epApp;
        private readonly IENAppService enApp;

        private String msg;
        private Exception exception;
        //USUARIO objeto = new USUARIO();
        //USUARIO objetoAntes = new USUARIO();
        List<vwContasAReceber> listaCR = new List<vwContasAReceber>();
        List<vwContasAPagar> listaCP = new List<vwContasAPagar>();
        List<vwLancamentosAPagar> listaLP = new List<vwLancamentosAPagar>();
        List<vwParcelamento> listaPC = new List<vwParcelamento>();
        List<vwExecutandoPositivo> listaEP = new List<vwExecutandoPositivo>();
        List<vwExecutandoNegativo> listaEN = new List<vwExecutandoNegativo>();
        String extensao;

        public DashboardController(ICRAppService crApps, ICPAppService cpApps, ILPAppService lpApps, IPCAppService pcApps, IEPAppService epApps, IENAppService enApps)
        {
            crApp = crApps;
            cpApp = cpApps;
            lpApp = lpApps;
            pcApp = pcApps;
            epApp = epApps;
            enApp = enApps;
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
            return RedirectToAction("MontarTelaDashboardReal", "Dashboard");
        }

        public ActionResult VoltarBase()
        {
            //if ((String)Session["Ativa"] == null)
            //{
            //    return RedirectToAction("Login", "ControleAcesso");
            //}
            return RedirectToAction("MontarTelaDashboardReal", "Dashboard");
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
            // Carrega listas principais
            //DateTime hoje = DateTime.Today.Date;
            DateTime hoje = Convert.ToDateTime("10/09/2019");
            listaCR = crApp.GetByData(hoje);
            listaCP = cpApp.GetByData(hoje);
            listaLP = lpApp.GetAllItens();
            listaPC = pcApp.GetAllItens();
            listaEP = epApp.GetAllItens();
            listaEN = enApp.GetAllItens();
            Session["ListaCR"] = listaCR;
            Session["ListaCP"] = listaCP;
            Session["ListaLP"] = listaLP;
            Session["ListaPC"] = listaPC;
            Session["ListaEP"] = listaEP;
            Session["ListaEN"] = listaEN;

            // Carrega listas dos filtros
            var listaCentroLucro = listaCR.Select(p => p.Centro_de_Lucro).Distinct().ToList();
            List<SelectListItem> listaCL = new List<SelectListItem>();
            foreach (var item in listaCentroLucro)
            {
                if (item != null)
                {
                    listaCL.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
                }
            }
            ViewBag.CentroLucro = new SelectList(listaCL, "Value", "Text");

            var listaCentroCusto = listaCP.Select(p => p.Centro_de_Custos).Distinct().ToList();
            List<SelectListItem> listaCC= new List<SelectListItem>();
            foreach (var item in listaCentroCusto)
            {
                if (item != null)
                {
                    listaCC.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
                }
            }
            ViewBag.CentroCusto = new SelectList(listaCC, "Value", "Text");

            // Carrega viewmodel filtro
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

            mod.EmissaoInicio = Convert.ToDateTime("01/09/2019");
            mod.EmissaoFinal = Convert.ToDateTime("30/09/2019");
            mod.VencimentoInicio = Convert.ToDateTime("01/09/2019");
            mod.VencimentoFinal = Convert.ToDateTime("30/09/2019");
            mod.RecebimentoInicio = Convert.ToDateTime("01/09/2019");
            mod.RecebimentoFinal = Convert.ToDateTime("30/09/2019");
            mod.PagamentoInicio = Convert.ToDateTime("01/09/2019");
            mod.PagamentoFinal = Convert.ToDateTime("30/09/2019");

            Session["RecIni"] = Convert.ToDateTime("01/09/2019");
            Session["RecFim"] = Convert.ToDateTime("30/09/2019");

            // Carrega Indicadores Diretos -- A SUBSTITUR
            decimal saldoBancario = Convert.ToDecimal(164604.20);
            ViewBag.SaldoBancario = saldoBancario;

            // Carrega Indicadores
            //decimal rec = listaCR.Where(p => p.Data_de_Recebimento.Value.Month == DateTime.Today.Date.Month & p.Data_de_Recebimento.Value.Year == DateTime.Today.Date.Year).Sum(p => p.Valor_Liquido);
            //decimal pag = listaCP.Where(p => p.Data_de_Pagamento.Value.Month == DateTime.Today.Date.Month & p.Data_de_Pagamento.Value.Year == DateTime.Today.Date.Year).Sum(p => p.Valor);
            //decimal lp = listaLP.Where(p => p.Data_de_Vencimento.Value.Month == DateTime.Today.Date.Month & p.Data_de_Vencimento.Value.Year == DateTime.Today.Date.Year).Sum(p => p.Valor);
            //decimal pc = listaPC.Sum(p => p.Valor_Bruto);

            Decimal rec = listaCR.Where(p => p.Data_de_Vencimento.Month == 9 & p.Data_de_Vencimento.Year == 2019).Sum(p => p.Valor_Liquido);
            Decimal pag = listaCP.Where(p => p.Data_de_Vencimento.Month == 9 & p.Data_de_Vencimento.Year == 2019).Sum(p => p.Valor);
            Decimal lp = listaLP.Where(p => p.Data_de_Vencimento.Value.Month == 9 & p.Data_de_Vencimento.Value.Year == 2019).Sum(p => p.Valor);
            Decimal pc = listaPC.Sum(p => p.Valor_Bruto);
            Decimal ep = listaEP.Sum(p => p.ExecutandoPositivo.Value);
            Decimal en = listaEN.Sum(p => p.ExecutandoNegativo.Value);

            ViewBag.Rec = rec;
            ViewBag.Pag = pag;
            ViewBag.Lp = lp;
            ViewBag.Pc = pc;
            ViewBag.ExecPositivo = ep;
            ViewBag.ExecNegativo = en;

            Session["Rec"] = rec;
            Session["Pag"] = pag;
            Session["LP"] = lp;
            Session["PC"] = pc;

            // Campos calculados
            Decimal result = (rec + ep + pc) - (pag + en + lp);
            Decimal saldo = result + saldoBancario;
            ViewBag.Resultado = result;
            ViewBag.SaldoTotal = saldo;

            return View(mod);
        }

        public ActionResult VerReceitasExpansao()
        {
            // Prepara view
            List<vwContasAReceber> listaCR = (List<vwContasAReceber>)Session["ListaCR"];
            ViewBag.ListaCR = listaCR;
            ViewBag.ListaCRNum = listaCR.Count;
            ViewBag.CRValor = (Decimal)Session["Rec"];
            return View();
        }

        [HttpPost]
        public JsonResult GetValorGraficoCR(Int32 id, Int32? meses)
        {
            if (meses == null)
            {
                meses = 3;
            }

            List<vwContasAReceber> lista = (List<vwContasAReceber>)Session["ListaCR"];
            DateTime data1 = (DateTime)Session["RecIni"];
            DateTime data2 = (DateTime)Session["RecFim"];
            Int32 mes = data1.Month;
            Int32 ano = data1.Year;
            Int32 numMes = ((data1.Year - data2.Year) * 12) + data1.Month - data2.Month;
            var hash = new Hashtable();
            for (int i = 1; i <= numMes; i++)
            {
                String label = mes.ToString().PadLeft(2, '0') + "/" + ano.ToString();
                Decimal valor = lista.Where(p => p.Data_de_Vencimento.Month == mes & p.Data_de_Vencimento.Year == ano).Sum(x => x.Valor_Liquido);
                hash.Add(label, valor);

                mes++;
                if (mes > 12)
                {
                    mes = 1;
                    ano++;
                }
            }
            return Json(hash);
        }

        public ActionResult VerTodosReceita()
        {
            // Prepara view
            List<vwContasAReceber> listaCR = (List<vwContasAReceber>)Session["ListaCR"];
            ViewBag.ListaCR = listaCR;
            ViewBag.ListaCRNum = listaCR.Count;
            ViewBag.CRValor = (Decimal)Session["Rec"];
            return View();
        }

    }
}