using GastosForms.MVC.Controller;
using MetroFramework.Controls;
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
        public TextBox Titulo { get; set; }
        public MetroRadioButton Debido { get; set; }
        public MetroRadioButton Credito { get; set; }
        public MetroRadioButton Alimentacao { get; set; }
        public MetroButton Cadastrar { get; set; }
        public DataGridView TabelaGastos { get; set; }
        public MetroButton Carregar { get;set; }
        public TextBox TxtDebito { get; set; }
        public TextBox TxtCredito { get; set; }
        public TextBox TxtAlimentacao { get; set; }
        public TextBox TxtId { get; set; }
        public MetroButton Cancelar { get; set; }
        public MetroButton Deletar { get; set; }
        public DateTimePicker Data { get;set;}
    }
}
