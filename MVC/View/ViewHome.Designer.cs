namespace GastosForms
{
    partial class ViewHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textGasto = new TextBox();
            radioDebito = new RadioButton();
            radioCredito = new RadioButton();
            radioAlimentacao = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textDesc = new RichTextBox();
            buttonRegistro = new Button();
            dataTableGastos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataTableGastos).BeginInit();
            SuspendLayout();
            // 
            // textGasto
            // 
            textGasto.Location = new Point(12, 39);
            textGasto.Name = "textGasto";
            textGasto.Size = new Size(143, 27);
            textGasto.TabIndex = 0;
            // 
            // radioDebito
            // 
            radioDebito.AutoSize = true;
            radioDebito.Checked = true;
            radioDebito.ForeColor = SystemColors.ActiveCaptionText;
            radioDebito.Location = new Point(12, 72);
            radioDebito.Name = "radioDebito";
            radioDebito.Size = new Size(73, 24);
            radioDebito.TabIndex = 1;
            radioDebito.TabStop = true;
            radioDebito.Text = "Débito";
            radioDebito.UseVisualStyleBackColor = true;
            // 
            // radioCredito
            // 
            radioCredito.AutoSize = true;
            radioCredito.Location = new Point(12, 102);
            radioCredito.Name = "radioCredito";
            radioCredito.Size = new Size(76, 24);
            radioCredito.TabIndex = 2;
            radioCredito.TabStop = true;
            radioCredito.Text = "Crédito";
            radioCredito.UseVisualStyleBackColor = true;
            // 
            // radioAlimentacao
            // 
            radioAlimentacao.AutoSize = true;
            radioAlimentacao.Location = new Point(12, 132);
            radioAlimentacao.Name = "radioAlimentacao";
            radioAlimentacao.Size = new Size(143, 24);
            radioAlimentacao.TabIndex = 3;
            radioAlimentacao.TabStop = true;
            radioAlimentacao.Text = "Vale Alimentação";
            radioAlimentacao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Valor gasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // textDesc
            // 
            textDesc.BorderStyle = BorderStyle.FixedSingle;
            textDesc.Location = new Point(208, 39);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(283, 76);
            textDesc.TabIndex = 6;
            textDesc.Text = "";
            // 
            // buttonRegistro
            // 
            buttonRegistro.Location = new Point(208, 121);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(283, 35);
            buttonRegistro.TabIndex = 7;
            buttonRegistro.Text = "Registre";
            buttonRegistro.UseVisualStyleBackColor = true;
            buttonRegistro.Click += CadastroContas;
            // 
            // dataTableGastos
            // 
            dataTableGastos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataTableGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTableGastos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3 });
            dataTableGastos.Location = new Point(12, 180);
            dataTableGastos.Name = "dataTableGastos";
            dataTableGastos.RowHeadersVisible = false;
            dataTableGastos.Size = new Size(913, 318);
            dataTableGastos.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Título";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Tipo";
            Column4.Name = "Column4";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 40F;
            Column2.HeaderText = "Gasto";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 40F;
            Column3.HeaderText = "Data";
            Column3.Name = "Column3";
            // 
            // ViewHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 510);
            Controls.Add(dataTableGastos);
            Controls.Add(buttonRegistro);
            Controls.Add(textDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioAlimentacao);
            Controls.Add(radioCredito);
            Controls.Add(radioDebito);
            Controls.Add(textGasto);
            Name = "ViewHome";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataTableGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textGasto;
        private RadioButton radioDebito;
        private RadioButton radioCredito;
        private RadioButton radioAlimentacao;
        private Label label1;
        private Label label2;
        private RichTextBox textDesc;
        private Button buttonRegistro;
        private DataGridView dataTableGastos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
