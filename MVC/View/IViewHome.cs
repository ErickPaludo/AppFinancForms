using GastosForms.MVC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosForms.MVC.View
{
    public interface IViewHome
    {
      void SetContoller(HomeController controller);
        public TextBox Valor { get; set; }
        public TextBox Descicao { get; set; }
        public RadioButton Debido { get; set; }
        public RadioButton Credito { get; set; }
        public RadioButton Alimentacao { get; set; }
        public Button Cadastrar { get; set; }
        public DataGridView TabelaGastos { get; set; }
        public Button Carregar { get;set; }
        public TextBox TxtDebito { get; set; }
        public TextBox TxtCredito { get; set; }
        public TextBox TxtAlimentacao { get; set; }
        public TextBox TxtId { get; set; }
    }
}
