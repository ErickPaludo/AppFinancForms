using GastosForms.MVC.Controller;
using GastosForms.MVC.View;
using GastosForms.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastosForms.MVC.Models
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
        }
        public void AddContas(string valor,string desc,RadioButton debito,RadioButton credito,RadioButton alimentacao)
        {
            try
            {
                DateTime date = DateTime.Now;
                int tipo = 0;

                if (debito.IsAccessible)
                {
                    tipo = 1;
                }
                else if (credito.IsAccessible)
                {
                    tipo = 2;
                }
                else
                {
                    tipo = 3;
                }


                if (!string.IsNullOrEmpty(valor)) { model.AddConta(new Contas(Convert.ToDouble(valor), desc, tipo, date)); }
                else
                {
                    MessageBox.Show("Erro!", "Alguns capos estão inválidos, verifique novamente!");
                }

                view.TabelaGastos.Rows.Add(desc, valor, date);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
