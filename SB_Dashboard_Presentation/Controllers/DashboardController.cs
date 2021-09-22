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
            // Variaveis
            Decimal rec = 0;
            Decimal pag = 0;
            Decimal lp = 0;
            Decimal pc = 0;
            Decimal ep = 0;
            Decimal en = 0;
            DateTime inicio = Convert.ToDateTime("01/" + DateTime.Today.Date.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Today.Date.Year.ToString());
            DateTime hoje = DateTime.Today.Date;

            // Carrega campos de filtro
            ModeloViewModel mod = new ModeloViewModel();
            if (Session["Filtro"] == null)
            {
                //mod.EmissaoInicio = inicio;
                //mod.EmissaoFinal = DateTime.Today.Date;
                //mod.VencimentoInicio = inicio;
                //mod.VencimentoFinal = DateTime.Today.Date;
                //mod.RecebimentoInicio = inicio;
                //mod.RecebimentoFinal = DateTime.Today.Date;
                //mod.PagamentoInicio = inicio;
                //mod.PagamentoFinal = DateTime.Today.Date;

                mod.EmissaoInicio = null;
                mod.EmissaoFinal = null;
                mod.VencimentoInicio = Convert.ToDateTime("01/09/2019");
                mod.VencimentoFinal = Convert.ToDateTime("30/09/2019");
                mod.RecebimentoInicio = null;
                mod.RecebimentoFinal = null;
                mod.PagamentoInicio = null;
                mod.PagamentoFinal = null;
                mod.CentroCusto = null;
                mod.CentroLucro = null;
                mod.Beneficiario = null;
                mod.Sacado = null;
                Session["Filtro"] = null;
                Session["RecIni"] = Convert.ToDateTime("01/09/2019");
                Session["RecFim"] = Convert.ToDateTime("30/09/2019");
                Session["DataBase"] = Convert.ToDateTime("01/09/2019");
            }
            else
            {
                mod = (ModeloViewModel)Session["Filtro"];
                Session["RecIni"] = mod.EmissaoInicio;
                Session["RecFim"] = mod.EmissaoFinal;
                Session["DataBase"] = mod.EmissaoInicio;
            }

            // Carrega Indicadores Diretos -- A SUBSTITUR
            decimal saldoBancario = Convert.ToDecimal(164604.20);
            ViewBag.SaldoBancario = saldoBancario;

            // Carrega listas principais
            if ((Int32)Session["CarregaListas"] == 0)
            {
                // Carrega listas dos filtros
                List<vwContasAReceber> listaCR1 = crApp.GetAllItens();
                var listaCentroLucro = listaCR1.Select(p => p.Centro_de_Lucro).Distinct().ToList();
                List<SelectListItem> listaCL = new List<SelectListItem>();
                foreach (var item in listaCentroLucro)
                {
                    if (item != null)
                    {
                        listaCL.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
                    }
                }
                SelectList cl = new SelectList(listaCL, "Value", "Text");
                ViewBag.CentroLucro = cl;
                Session["CL"] = cl;

                var listaSacado = listaCR1.Select(p => p.Sacado).Distinct().ToList();
                List<SelectListItem> sacado = new List<SelectListItem>();
                foreach (var item in listaSacado)
                {
                    if (item != null)
                    {
                        sacado.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
                    }
                }
                SelectList sa = new SelectList(sacado, "Value", "Text");
                ViewBag.Sacados = sa;
                Session["SA"] = sa;

                List<vwContasAPagar> listaCP1 = cpApp.GetAllItens();
                var listaCentroCusto = listaCP1.Select(p => p.Centro_de_Custos).Distinct().ToList();
                List<SelectListItem> listaCC = new List<SelectListItem>();
                foreach (var item in listaCentroCusto)
                {
                    if (item != null)
                    {
                        listaCC.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
                    }
                }
                SelectList cc = new SelectList(listaCC, "Value", "Text");
                ViewBag.CentroCusto = cc;
                Session["CC"] = cc;


                var listaBeneficiario = listaCP1.Select(p => p.Beneficario).Distinct().ToList();
                List<SelectListItem> beneficiario = new List<SelectListItem>();
                foreach (var item in listaBeneficiario)
                {
                    if (item != null)
                    {
                        beneficiario.Add(new SelectListItem() { Text = item.ToString(), Value = item.ToString() });
                    }
                }
                ViewBag.Beneficiarios = new SelectList(beneficiario, "Value", "Text");
                SelectList be = new SelectList(beneficiario, "Value", "Text");
                ViewBag.Beneficiarios = be;
                Session["BE"] = be;

                hoje = Convert.ToDateTime("10/09/2019");
                listaCR = listaCR1.Where(p => p.Data_de_Vencimento.Month == hoje.Month & p.Data_de_Vencimento.Year == hoje.Year).ToList();
                listaCP = listaCP1.Where(p => p.Data_de_Vencimento.Month == hoje.Month & p.Data_de_Vencimento.Year == hoje.Year).ToList();
                listaLP = lpApp.GetAllItens().Where(p => p.Data_de_Vencimento.Value.Month == 9 & p.Data_de_Vencimento.Value.Year == 2019).ToList();
                listaPC = pcApp.GetAllItens();
                listaEP = epApp.GetAllItens();
                listaEN = enApp.GetAllItens();
                Session["ListaCR"] = listaCR;
                Session["ListaCP"] = listaCP;
                Session["ListaLP"] = listaLP;
                Session["ListaPC"] = listaPC;
                Session["ListaEP"] = listaEP;
                Session["ListaEN"] = listaEN;
                Session["CarregaListas"] = 1;

                rec = listaCR.Sum(p => p.Valor_Liquido);
                pag = listaCP.Sum(p => p.Valor);
                lp = listaLP.Sum(p => p.Valor);
                pc = listaPC.Sum(p => p.Valor_Bruto);
                ep = listaEP.Sum(p => p.ExecutandoPositivo.Value);
                en = listaEN.Sum(p => p.ExecutandoNegativo.Value);

                ViewBag.FalhaCR = listaCR.Count > 0 ? 0 : 1;
                ViewBag.FalhaCP = listaCP.Count > 0 ? 0 : 1;
                ViewBag.FalhaPC = listaPC.Count > 0 ? 0 : 1;
                ViewBag.FalhaLP = listaLP.Count > 0 ? 0 : 1;
            }
            else
            {
                listaCR = (List<vwContasAReceber>)Session["ListaCR"];
                listaCP = (List<vwContasAPagar>)Session["ListaCP"];
                listaPC = (List<vwParcelamento>)Session["ListaPC"];
                listaLP = (List<vwLancamentosAPagar>)Session["ListaLP"];
                listaEN = (List<vwExecutandoNegativo>)Session["ListaEN"];
                listaEP = (List<vwExecutandoPositivo>)Session["ListaEP"];
                Session["CarregaListas"] = 1;

                rec = listaCR.Sum(p => p.Valor_Liquido);
                pag = listaCP.Sum(p => p.Valor);
                lp = listaLP.Sum(p => p.Valor);
                pc = listaPC.Sum(p => p.Valor_Bruto);
                ep = listaEP.Sum(p => p.ExecutandoPositivo.Value);
                en = listaEN.Sum(p => p.ExecutandoNegativo.Value);

                ViewBag.FalhaCR = (Int32)Session["FalhaCR"];
                ViewBag.FalhaCP = (Int32)Session["FalhaCP"];
                ViewBag.FalhaPC = (Int32)Session["FalhaPC"];
                ViewBag.FalhaLP = (Int32)Session["FalhaLP"];

                ViewBag.Beneficiarios = (SelectList)Session["BE"];
                ViewBag.Sacado = (SelectList)Session["SA"];
                ViewBag.CentroCusto = (SelectList)Session["CC"];
                ViewBag.CentroLucro = (SelectList)Session["CL"];
            }

            // Configura view
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

            // Monta linha do filtro
            String linhaFiltro = String.Empty;
            if (mod.EmissaoInicio != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Emissão-Início: " + mod.EmissaoInicio.Value.ToShortDateString();
                }
                else
                {
                    linhaFiltro += " | Emissão-Início: " + mod.EmissaoInicio.Value.ToShortDateString();
                }
            }
            if (mod.EmissaoFinal != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Emissão-Final: " + mod.EmissaoFinal.Value.ToShortDateString();
                }
                else
                {
                    linhaFiltro += " | Emissão-Final: " + mod.EmissaoFinal.Value.ToShortDateString();
                }
            }
            if (mod.VencimentoInicio != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Vencimento-Início: " + mod.VencimentoInicio.Value.ToShortDateString();
                }
                else
                {
                    linhaFiltro += " | Vencimento-Início: " + mod.VencimentoInicio.Value.ToShortDateString();
                }
            }
            if (mod.VencimentoFinal != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Vencimento-Final: " + mod.VencimentoFinal.Value.ToShortDateString();
                }
                else
                {
                    linhaFiltro += " | Vencimento-Final: " + mod.VencimentoFinal.Value.ToShortDateString();
                }
            }
            if (mod.PagamentoInicio != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Pagamento-Início: " + mod.PagamentoInicio.Value.ToShortDateString();
                }
                else
                {
                    linhaFiltro += " | Pagamento-Início: " + mod.PagamentoInicio.Value.ToShortDateString();
                }
            }
            if (mod.PagamentoFinal != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Pagamento-Final: " + mod.PagamentoFinal.Value.ToShortDateString();
                }
                else
                {
                    linhaFiltro += " | Pagamento-Final: " + mod.PagamentoFinal.Value.ToShortDateString();
                }
            }
            if (mod.CentroCusto != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Centro de Custo: " + mod.CentroCusto;
                }
                else
                {
                    linhaFiltro += " | Centro de Custo: " + mod.CentroCusto;
                }
            }
            if (mod.CentroLucro != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Centro de Lucro: " + mod.CentroLucro;
                }
                else
                {
                    linhaFiltro += " | Centro de Lucro: " + mod.CentroLucro;
                }
            }
            if (mod.Beneficiario != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Beneficário: " + mod.Beneficiario;
                }
                else
                {
                    linhaFiltro += " | Beneficário: " + mod.Beneficiario;
                }
            }
            if (mod.Sacado != null)
            {
                if (linhaFiltro == String.Empty)
                {
                    linhaFiltro = "Sacado: " + mod.Sacado;
                }
                else
                {
                    linhaFiltro += " | Sacado: " + mod.Sacado;
                }
            }
            ViewBag.LinhaFiltro = linhaFiltro;

            // Retorna
            return View(mod);
        }

        public ActionResult VerReceitasExpansao()
        {
            // Prepara grafico
            String ano = ((DateTime)Session["DataBase"]).Year.ToString();
            ViewBag.Ano = ano;            
            
            // Prepara view
            List<vwContasAReceber> listaCR = (List<vwContasAReceber>)Session["ListaCR"];
            ViewBag.ListaCR = listaCR;
            ViewBag.ListaCRNum = listaCR.Count;
            ViewBag.CRValor = (Decimal)Session["Rec"];
            return View();
        }

        public ActionResult VerDespesasExpansao()
        {
            // Prepara grafico
            String ano = ((DateTime)Session["DataBase"]).Year.ToString();
            ViewBag.Ano = ano;

            // Prepara view
            List<vwContasAPagar> listaCP = (List<vwContasAPagar>)Session["ListaCP"];
            ViewBag.ListaCP = listaCP;
            ViewBag.ListaCPNum = listaCP.Count;
            ViewBag.CPValor = (Decimal)Session["Pag"];
            return View();
        }

        public ActionResult VerParcelamentosExpansao()
        {
            // Prepara grafico
            String ano = ((DateTime)Session["DataBase"]).Year.ToString();
            ViewBag.Ano = ano;

            // Prepara view
            List<vwParcelamento> listaPC = (List<vwParcelamento>)Session["ListaPC"];
            ViewBag.listaPC = listaPC;
            ViewBag.listaPCNum = listaPC.Count;
            ViewBag.PCValor = (Decimal)Session["PC"];
            return View();
        }

        public ActionResult VerLancamentosExpansao()
        {
            // Prepara grafico
            String ano = ((DateTime)Session["DataBase"]).Year.ToString();
            ViewBag.Ano = ano;

            // Prepara view
            List<vwLancamentosAPagar> listaLP = (List<vwLancamentosAPagar>)Session["ListaLP"];
            ViewBag.listaLP = listaLP;
            ViewBag.listaLPNum = listaLP.Count;
            ViewBag.LPValor = (Decimal)Session["LP"];
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

        public ActionResult VerTodosDespesas()
        {
            // Prepara view
            List<vwContasAPagar> listaCP = (List<vwContasAPagar>)Session["listaCP"];
            ViewBag.listaCP = listaCP;
            ViewBag.listaCPNUm = listaCP.Count;
            ViewBag.CPValor = (Decimal)Session["Pag"];
            return View();
        }

        public ActionResult VerTodosParcelamentos()
        {
            // Prepara view
            List<vwParcelamento> listaPC = (List<vwParcelamento>)Session["listaPC"];
            ViewBag.listaPC = listaPC;
            ViewBag.listaPCNum = listaPC.Count;
            ViewBag.PCValor = (Decimal)Session["PC"];
            return View();
        }

        public ActionResult VerTodosLancamentos()
        {
            // Prepara view
            List<vwLancamentosAPagar> listaLP = (List<vwLancamentosAPagar>)Session["listaLP"];
            ViewBag.listaLP = listaLP;
            ViewBag.listaLPNum = listaLP.Count;
            ViewBag.LPValor = (Decimal)Session["LP"];
            return View();
        }

        public ActionResult RetirarFiltro()
        {
            Session["CarregaLista"] = 0;
            Session["Filtro"] = null;
            return RedirectToAction("MontarTelaDashboardReal");
        }

        [HttpPost]
        public ActionResult FiltrarGeralDashboard(ModeloViewModel item)
        {
            try
            {
                // Executa a operação
                Session["Filtro"] = item;

                // Receitas
                List<vwContasAReceber> listaCR = new List<vwContasAReceber>();
                Int32 volta = crApp.ExecuteFilter(item.EmissaoInicio, item.EmissaoFinal, item.VencimentoInicio, item.VencimentoFinal, item.RecebimentoInicio, item.RecebimentoFinal, item.CentroLucro, item.Sacado, out listaCR);
                if (volta == 1)
                {
                    Session["FalhaCR"] = 1;
                }

                // Despesas
                List<vwContasAPagar> listaCP = new List<vwContasAPagar>();
                volta = cpApp.ExecuteFilter(item.EmissaoInicio, item.EmissaoFinal, item.VencimentoInicio, item.VencimentoFinal, item.PagamentoInicio, item.PagamentoFinal, item.CentroCusto, item.Beneficiario, out listaCP);
                if (volta == 1)
                {
                    Session["FalhaCP"] = 1;
                }

                // Parcelamentos
                List<vwParcelamento> listaPC = new List<vwParcelamento>();
                volta = pcApp.ExecuteFilter(item.VencimentoInicio, item.VencimentoFinal, item.CentroLucro, item.Sacado, out listaPC);
                if (volta == 1)
                {
                    Session["FalhaPC"] = 1;
                }

                // Lancamentos
                List<vwLancamentosAPagar> listaLP = new List<vwLancamentosAPagar>();
                volta = lpApp.ExecuteFilter(item.EmissaoInicio, item.EmissaoFinal, item.VencimentoInicio, item.VencimentoFinal, item.CentroCusto, item.CentroLucro, item.Beneficiario, out listaLP);
                if (volta == 1)
                {
                    Session["FalhaLP"] = 1;
                }

                // Sucesso
                Session["CarregaLista"] = 1;
                Session["ListaCR"] = listaCR;
                Session["ListaCP"] = listaCP;
                Session["ListaPC"] = listaPC;
                Session["ListaLP"] = listaLP;
                return RedirectToAction("MontarTelaDashboardReal");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("MontarTelaDashboardReal");
            }
        }

    }
}