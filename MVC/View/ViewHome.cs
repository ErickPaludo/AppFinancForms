using GastosForms.MVC.Controller;
using GastosForms.MVC.View;
using MetroFramework.Controls;
using System.Reflection.Metadata.Ecma335;

namespace GastosForms
{
    public partial class ViewHome : MetroFramework.Forms.MetroForm, IViewHome
    {
        HomeController controller;
        public ViewHome()
        {
            InitializeComponent();
        }

        public TextBox Valor { get { return textGasto; } set { textGasto = value; } }
        public TextBox Titulo { get { return textDesc; } set { textDesc = value; } }
        public MetroRadioButton Debido { get { return radioDebito; } set { radioDebito = value; } }
        public MetroRadioButton Credito { get { return radioCredito; } set { radioCredito = value; } }
        public MetroRadioButton Alimentacao { get { return radioAlimentacao; } set { radioAlimentacao = value; } }
        public MetroButton Cadastrar { get { return buttonRegistro; } set { buttonRegistro = value; } }
        public DataGridView TabelaGastos { get { return dataTableGastos; } set { dataTableGastos = value; } }
        public MetroButton Carregar { get { return buttonAtualiza; } set { buttonAtualiza = value; } }
        public TextBox TxtDebito { get { return textDebito; } set { textDebito = value; } }
        public TextBox TxtCredito { get { return textCredito; } set { textCredito = value; } }
        public TextBox TxtAlimentacao { get { return textAlimentacao; } set { textAlimentacao = value; } }
        public TextBox TxtId { get { return textId; } set { textId = value; } }
        public MetroButton Cancelar { get { return buttonCancelar; } set { buttonCancelar = value; } }
        public MetroButton Deletar { get { return buttonDeletar; } set { buttonDeletar = value; } } 
        public DateTimePicker Data { get { return data; } set { data = value; } }


        public void SetContoller(HomeController controller)
        {
            this.controller = controller;
        }

        private void CadastroContas(object sender, EventArgs e)
        {
            controller.AddContas(textGasto.Text, textDesc.Text, radioDebito, radioCredito, radioAlimentacao);
        }

        private void Atualiza(object sender, EventArgs e)
        {
            controller.Atualiza();
        }

        private void SelecionaGasto(object sender, DataGridViewCellEventArgs e)
        {

            controller.SelecionaConta(Convert.ToInt32(dataTableGastos.Rows[e.RowIndex].Cells[4].Value));

        }

        private void CancelaEdit(object sender, EventArgs e)
        {
            controller.Cancelar();
        }

        private void Deleta(object sender, EventArgs e)
        {
            controller.Delete();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
