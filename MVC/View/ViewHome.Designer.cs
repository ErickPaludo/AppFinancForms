﻿using MetroFramework;
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
            dateinicial = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            data = new DateTimePicker();
            metroLabel1 = new MetroLabel();
            ((System.ComponentModel.ISupportInitialize)dataTableGastos).BeginInit();
            SuspendLayout();
            // 
            // textGasto
            // 
            textGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textGasto.Cursor = Cursors.Hand;
            textGasto.Location = new Point(26, 145);
            textGasto.Name = "textGasto";
            textGasto.PlaceholderText = "R$00,00";
            textGasto.Size = new Size(143, 27);
            textGasto.TabIndex = 2;
            // 
            // radioDebito
            // 
            radioDebito.AutoSize = true;
            radioDebito.Checked = true;
            radioDebito.ForeColor = SystemColors.ActiveCaptionText;
            radioDebito.Location = new Point(331, 124);
            radioDebito.Name = "radioDebito";
            radioDebito.Size = new Size(58, 15);
            radioDebito.Style = MetroColorStyle.Green;
            radioDebito.TabIndex = 3;
            radioDebito.TabStop = true;
            radioDebito.Text = "Débito";
            radioDebito.UseSelectable = true;
            radioDebito.UseVisualStyleBackColor = true;
            // 
            // radioCredito
            // 
            radioCredito.AutoSize = true;
            radioCredito.Location = new Point(449, 124);
            radioCredito.Name = "radioCredito";
            radioCredito.Size = new Size(62, 15);
            radioCredito.Style = MetroColorStyle.Green;
            radioCredito.TabIndex = 4;
            radioCredito.TabStop = true;
            radioCredito.Text = "Crédito";
            radioCredito.UseSelectable = true;
            radioCredito.UseVisualStyleBackColor = true;
            // 
            // radioAlimentacao
            // 
            radioAlimentacao.AutoSize = true;
            radioAlimentacao.Location = new Point(567, 124);
            radioAlimentacao.Name = "radioAlimentacao";
            radioAlimentacao.Size = new Size(114, 15);
            radioAlimentacao.Style = MetroColorStyle.Green;
            radioAlimentacao.TabIndex = 5;
            radioAlimentacao.TabStop = true;
            radioAlimentacao.Text = "Vale Alimentação";
            radioAlimentacao.UseSelectable = true;
            radioAlimentacao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 119);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 4;
            label1.Text = "Valor gasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 5;
            label2.Text = "Título";
            // 
            // buttonRegistro
            // 
            buttonRegistro.BackColor = Color.FromArgb(0, 192, 0);
            buttonRegistro.Cursor = Cursors.Hand;
            buttonRegistro.ForeColor = Color.FromArgb(0, 192, 0);
            buttonRegistro.Location = new Point(26, 181);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(143, 35);
            buttonRegistro.Style = MetroColorStyle.Green;
            buttonRegistro.TabIndex = 6;
            buttonRegistro.Text = "Registre";
            buttonRegistro.UseCompatibleTextRendering = true;
            buttonRegistro.UseSelectable = true;
            buttonRegistro.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataTableGastos.DefaultCellStyle = dataGridViewCellStyle3;
            dataTableGastos.Location = new Point(26, 261);
            dataTableGastos.Name = "dataTableGastos";
            dataTableGastos.ReadOnly = true;
            dataTableGastos.RowHeadersVisible = false;
            dataTableGastos.Size = new Size(888, 331);
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
            buttonAtualiza.Cursor = Cursors.Hand;
            buttonAtualiza.ImageKey = "(nenhum)";
            buttonAtualiza.Location = new Point(797, 221);
            buttonAtualiza.Name = "buttonAtualiza";
            buttonAtualiza.Size = new Size(117, 35);
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
            textDesc.Cursor = Cursors.Hand;
            textDesc.Location = new Point(26, 91);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(228, 27);
            textDesc.TabIndex = 1;
            // 
            // textDebito
            // 
            textDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textDebito.Location = new Point(331, 91);
            textDebito.Name = "textDebito";
            textDebito.ReadOnly = true;
            textDebito.Size = new Size(112, 27);
            textDebito.TabIndex = 11;
            textDebito.TextAlign = HorizontalAlignment.Center;
            // 
            // textCredito
            // 
            textCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textCredito.Location = new Point(449, 91);
            textCredito.Name = "textCredito";
            textCredito.ReadOnly = true;
            textCredito.Size = new Size(112, 27);
            textCredito.TabIndex = 12;
            textCredito.TextAlign = HorizontalAlignment.Center;
            // 
            // textAlimentacao
            // 
            textAlimentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textAlimentacao.Location = new Point(567, 91);
            textAlimentacao.Name = "textAlimentacao";
            textAlimentacao.ReadOnly = true;
            textAlimentacao.Size = new Size(112, 27);
            textAlimentacao.TabIndex = 13;
            textAlimentacao.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 63);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 14;
            label3.Text = "Débito";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 63);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 15;
            label4.Text = "Crédito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 63);
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
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Location = new Point(26, 221);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(65, 31);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseCompatibleTextRendering = true;
            buttonCancelar.UseSelectable = true;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Visible = false;
            buttonCancelar.Click += CancelaEdit;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Cursor = Cursors.Hand;
            buttonDeletar.ForeColor = Color.Red;
            buttonDeletar.Location = new Point(104, 221);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(65, 31);
            buttonDeletar.Style = MetroColorStyle.Red;
            buttonDeletar.TabIndex = 8;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseSelectable = true;
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Visible = false;
            buttonDeletar.Click += Deleta;
            // 
            // dateinicial
            // 
            dateinicial.Format = DateTimePickerFormat.Short;
            dateinicial.Location = new Point(683, 229);
            dateinicial.Margin = new Padding(3, 4, 3, 4);
            dateinicial.Name = "dateinicial";
            dateinicial.Size = new Size(108, 27);
            dateinicial.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(569, 229);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 27);
            dateTimePicker1.TabIndex = 18;
           
            // 
            // data
            // 
            data.CustomFormat = "dd/MM/yyyy hh:mm";
            data.Format = DateTimePickerFormat.Custom;
            data.Location = new Point(184, 145);
            data.Margin = new Padding(3, 4, 3, 4);
            data.Name = "data";
            data.Size = new Size(143, 27);
            data.TabIndex = 19;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new Point(184, 122);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(36, 19);
            metroLabel1.TabIndex = 20;
            metroLabel1.Text = "Data";
            // 
            // ViewHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 605);
            Controls.Add(metroLabel1);
            Controls.Add(data);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateinicial);
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
            Padding = new Padding(21, 80, 21, 20);
            Style = MetroColorStyle.Green;
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
        private DateTimePicker dateinicial;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker data;
        private MetroLabel metroLabel1;
    }
}
