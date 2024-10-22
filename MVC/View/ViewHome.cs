using GastosForms.MVC.Models;
using GastosForms.MVC.View;
using System.Reflection.Metadata.Ecma335;

namespace GastosForms
{
    public partial class ViewHome : Form, IViewHome
    {
        HomeController controller;
        public ViewHome()
        {
            InitializeComponent();
        }

        public TextBox Valor { get { return textGasto; } set { textGasto = value; } }
        public RichTextBox Descicao { get { return textDesc; } set { textDesc = value; } }
        public RadioButton Debido { get { return radioDebito; } set { radioDebito = value; } }
        public RadioButton Credito { get { return radioCredito; } set { radioCredito = value; } }
        public RadioButton Alimentacao { get { return radioAlimentacao; } set { radioAlimentacao = value; } }
        public Button Cadastrar { get { return buttonRegistro; } set { buttonRegistro = value; } }
        public DataGridView TabelaGastos { get { return dataTableGastos; } set { dataTableGastos = value; } }

        public void SetContoller(HomeController controller)
        {
            this.controller = controller;
        }

        private void CadastroContas(object sender, EventArgs e)
        {
            controller.AddContas(textGasto.Text, textDesc.Text, radioDebito, radioCredito, radioAlimentacao);
        }
    }
}
