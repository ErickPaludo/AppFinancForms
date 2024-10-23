using GastosForms.MVC.View;
using GastosForms.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using GastosForms.MVC.Models;
using Microsoft.VisualBasic;

namespace GastosForms.MVC.Controller
{
    public class HomeController
    {
        IViewHome view;
        HomeModel model;

        public HomeController()
        {
        }

        public HomeController(IViewHome view, HomeModel model)
        {
            this.view = view;
            this.model = model;
            view.SetContoller(this);
            Atualiza();
        }

        public async Task AddContas(string valor, string desc, RadioButton debito, RadioButton credito, RadioButton alimentacao)
        {
            try
            {
                DateTime date = DateTime.Now;
                int tipo = 0;

                if (debito.Checked)
                {
                    tipo = 1;
                }
                else if (credito.Checked)
                {
                    tipo = 2;
                }
                else
                {
                    tipo = 3;
                }


                if (!string.IsNullOrEmpty(valor))
                {
                    if (string.IsNullOrEmpty(view.TxtId.Text))
                    {
                        await model.EnviaContas(new Contas(Convert.ToDouble(valor), desc, tipo, date));
                    }
                    else
                    {
                        ContasRec obj =  new ContasRec{id = Convert.ToInt32(view.TxtId.Text), valor = Convert.ToDouble(valor), titulo = desc, tipo = tipo, data = date};

                        model.AtualizaContas(obj);
                    }
                }
                else
                {
                    MessageBox.Show("Erro!", "Alguns capos estão inválidos, verifique novamente!");
                }

                await Atualiza();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public async Task SelecionaConta(int id)
        {
            ContasList objeto = await RecHttp.ExecutaRec("GET_ID", id);

            foreach (var obj in objeto.contasLista)
            {
                view.Valor.Text = obj.valor.ToString();
                view.Descicao.Text = obj.titulo;
                view.TxtId.Text = obj.id.ToString();
                switch (obj.tipo)
                {
                    case 1:
                        view.Debido.Checked = true;
                        break;
                    case 2:
                        view.Credito.Checked = true;
                        break;
                    case 3:
                        view.Alimentacao.Checked = true;
                        break;

                }

            }

        }

        public async Task Atualiza()
        {
            Clear();
            await model.RecebeContas();
            foreach (var obj in model.Contas)
            {
                view.TabelaGastos.Rows.Add(obj.titulo, Util.Desconverter(obj.tipo), obj.valor, obj.data, obj.id);
            }
            view.TxtDebito.Text = model.Calcula(1).ToString("f2");
            view.TxtCredito.Text = model.Calcula(2).ToString();
            view.TxtAlimentacao.Text = model.Calcula(3).ToString();
        }

        public void Clear()
        {
            view.TabelaGastos.Rows.Clear();
            view.Valor.Text = string.Empty;
            view.Descicao.Text = string.Empty;
            view.Descicao.IsAccessible = true;
            view.TxtCredito.Text = string.Empty;
            view.TxtDebito.Text = string.Empty;
            view.TxtAlimentacao.Text = string.Empty;
            view.TxtId.Text = string.Empty;
        }
    }
}
