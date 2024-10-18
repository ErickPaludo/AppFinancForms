namespace GastosForms
{
    partial class Form1
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
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(12, 72);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Débito";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 102);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Crédito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 132);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(143, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vale Alimentação";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Valor gasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 16);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(208, 39);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(283, 76);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(208, 121);
            button1.Name = "button1";
            button1.Size = new Size(118, 35);
            button1.TabIndex = 7;
            button1.Text = "Registre";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(913, 318);
            dataGridView1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(716, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 510);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
    }
}
