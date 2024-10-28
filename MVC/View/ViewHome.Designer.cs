using MetroFramework;
using MetroFramework.Controls;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textGasto = new TextBox();
            radioDebito = new MetroRadioButton();
            radioCredito = new MetroRadioButton();
            radioAlimentacao = new MetroRadioButton();
            label1 = new MetroLabel();
            label2 = new MetroLabel();
            buttonRegistro = new MetroButton();
            dataTableGastos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buttonAtualiza = new MetroButton();
            textDesc = new TextBox();
            textDebito = new TextBox();
            textCredito = new TextBox();
            textAlimentacao = new TextBox();
            label3 = new MetroLabel();
            label4 = new MetroLabel();
            label5 = new MetroLabel();
            textId = new TextBox();
            buttonCancelar = new MetroButton();
            buttonDeletar = new MetroButton();
            ((System.ComponentModel.ISupportInitialize)dataTableGastos).BeginInit();
            SuspendLayout();
            // 
            // textGasto
            // 
            textGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textGasto.Location = new Point(26, 138);
            textGasto.Name = "textGasto";
            textGasto.Size = new Size(143, 27);
            textGasto.TabIndex = 0;
            // 
            // radioDebito
            // 
            radioDebito.AutoSize = true;
            radioDebito.Checked = true;
            radioDebito.ForeColor = SystemColors.ActiveCaptionText;
            radioDebito.Location = new Point(274, 119);
            radioDebito.Name = "radioDebito";
            radioDebito.Size = new Size(58, 15);
            radioDebito.TabIndex = 1;
            radioDebito.TabStop = true;
            radioDebito.Text = "Débito";
            radioDebito.UseSelectable = true;
            radioDebito.UseVisualStyleBackColor = true;
            // 
            // radioCredito
            // 
            radioCredito.AutoSize = true;
            radioCredito.Location = new Point(392, 119);
            radioCredito.Name = "radioCredito";
            radioCredito.Size = new Size(62, 15);
            radioCredito.TabIndex = 2;
            radioCredito.TabStop = true;
            radioCredito.Text = "Crédito";
            radioCredito.UseSelectable = true;
            radioCredito.UseVisualStyleBackColor = true;
            // 
            // radioAlimentacao
            // 
            radioAlimentacao.AutoSize = true;
            radioAlimentacao.Location = new Point(510, 119);
            radioAlimentacao.Name = "radioAlimentacao";
            radioAlimentacao.Size = new Size(114, 15);
            radioAlimentacao.TabIndex = 3;
            radioAlimentacao.TabStop = true;
            radioAlimentacao.Text = "Vale Alimentação";
            radioAlimentacao.UseSelectable = true;
            radioAlimentacao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 115);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 4;
            label1.Text = "Valor gasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 62);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 5;
            label2.Text = "Título";
            // 
            // buttonRegistro
            // 
            buttonRegistro.Location = new Point(26, 171);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(143, 35);
            buttonRegistro.TabIndex = 7;
            buttonRegistro.Text = "Registre";
            buttonRegistro.UseCompatibleTextRendering = true;
            buttonRegistro.UseSelectable = true;
            buttonRegistro.UseVisualStyleBackColor = true;
            buttonRegistro.Click += CadastroContas;
            // 
            // dataTableGastos
            // 
            dataTableGastos.AllowUserToAddRows = false;
            dataTableGastos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataTableGastos.BackgroundColor = SystemColors.ButtonHighlight;
            dataTableGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataTableGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataTableGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTableGastos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataTableGastos.DefaultCellStyle = dataGridViewCellStyle3;
            dataTableGastos.Location = new Point(26, 249);
            dataTableGastos.Name = "dataTableGastos";
            dataTableGastos.ReadOnly = true;
            dataTableGastos.RowHeadersVisible = false;
            dataTableGastos.Size = new Size(888, 343);
            dataTableGastos.TabIndex = 8;
            dataTableGastos.CellDoubleClick += SelecionaGasto;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Título";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Tipo";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 40F;
            Column2.HeaderText = "Gasto";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 40F;
            Column3.HeaderText = "Data";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 25F;
            Column5.HeaderText = "Id";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // buttonAtualiza
            // 
            buttonAtualiza.ImageKey = "(nenhum)";
            buttonAtualiza.Location = new Point(798, 195);
            buttonAtualiza.Name = "buttonAtualiza";
            buttonAtualiza.Size = new Size(116, 35);
            buttonAtualiza.TabIndex = 9;
            buttonAtualiza.Text = "Atualiza";
            buttonAtualiza.UseCompatibleTextRendering = true;
            buttonAtualiza.UseSelectable = true;
            buttonAtualiza.UseVisualStyleBackColor = true;
            buttonAtualiza.Click += Atualiza;
            // 
            // textDesc
            // 
            textDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textDesc.Location = new Point(26, 85);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(228, 27);
            textDesc.TabIndex = 10;
            // 
            // textDebito
            // 
            textDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textDebito.Location = new Point(274, 85);
            textDebito.Name = "textDebito";
            textDebito.Size = new Size(112, 27);
            textDebito.TabIndex = 11;
            // 
            // textCredito
            // 
            textCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textCredito.Location = new Point(392, 85);
            textCredito.Name = "textCredito";
            textCredito.Size = new Size(112, 27);
            textCredito.TabIndex = 12;
            // 
            // textAlimentacao
            // 
            textAlimentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textAlimentacao.Location = new Point(510, 85);
            textAlimentacao.Name = "textAlimentacao";
            textAlimentacao.Size = new Size(112, 27);
            textAlimentacao.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 63);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 14;
            label3.Text = "Débito";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 62);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 15;
            label4.Text = "Crédito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 59);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 16;
            label5.Text = "Alimentação";
            // 
            // textId
            // 
            textId.Location = new Point(0, 0);
            textId.Name = "textId";
            textId.Size = new Size(100, 27);
            textId.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(26, 212);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(65, 31);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseCompatibleTextRendering = true;
            buttonCancelar.UseSelectable = true;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Visible = false;
            buttonCancelar.Click += CancelaEdit;
            // 
            // buttonDeletar
            // 
            buttonDeletar.ForeColor = Color.Red;
            buttonDeletar.Location = new Point(104, 212);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(65, 31);
            buttonDeletar.TabIndex = 19;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseCompatibleTextRendering = true;
            buttonDeletar.UseSelectable = true;
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Visible = false;
            buttonDeletar.Click += Deleta;
            // 
            // ViewHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 606);
            Controls.Add(buttonDeletar);
            Controls.Add(buttonCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textAlimentacao);
            Controls.Add(textCredito);
            Controls.Add(textDebito);
            Controls.Add(textDesc);
            Controls.Add(buttonAtualiza);
            Controls.Add(dataTableGastos);
            Controls.Add(buttonRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioAlimentacao);
            Controls.Add(radioCredito);
            Controls.Add(radioDebito);
            Controls.Add(textGasto);
            Name = "ViewHome";
            Text = "Controle de Gastos";
            ((System.ComponentModel.ISupportInitialize)dataTableGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textGasto;
        private MetroRadioButton radioDebito;
        private MetroRadioButton radioCredito;
        private MetroRadioButton radioAlimentacao;
        private MetroLabel label1;
        private MetroLabel label2;
        private MetroButton buttonRegistro;
        private DataGridView dataTableGastos;
        private MetroButton buttonAtualiza;
        private TextBox textDesc;
        private TextBox textDebito;
        private TextBox textCredito;
        private TextBox textAlimentacao;
        private MetroLabel label3;
        private MetroLabel label4;
        private MetroLabel label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private TextBox textId;
        private MetroButton buttonCancelar;
        private MetroButton buttonDeletar;
    }
}
