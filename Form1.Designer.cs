namespace Practica_2_U4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCliente = new TextBox();
            txtMonto = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label8 = new Label();
            txtSaldo = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 79);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 163);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 2;
            label3.Text = "Monto:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(209, 72);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 39);
            txtCliente.TabIndex = 3;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(209, 156);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(200, 39);
            txtMonto.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(590, 108);
            button1.Name = "button1";
            button1.Size = new Size(206, 87);
            button1.TabIndex = 5;
            button1.Text = "Abrir cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 274);
            label4.Name = "label4";
            label4.Size = new Size(160, 32);
            label4.TabIndex = 6;
            label4.Text = "Transacciones";
            // 
            // button2
            // 
            button2.Location = new Point(99, 335);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 7;
            button2.Text = "DEPOSITO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(324, 335);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "RETIRO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 450);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 9;
            label5.Text = "Historial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 482);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 10;
            label6.Text = "Depositos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 482);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 11;
            label7.Text = "Retiros";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(99, 537);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 260);
            listBox1.TabIndex = 12;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 32;
            listBox2.Location = new Point(396, 537);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(240, 260);
            listBox2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(718, 594);
            label8.Name = "label8";
            label8.Size = new Size(73, 32);
            label8.TabIndex = 14;
            label8.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(718, 645);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(200, 39);
            txtSaldo.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(718, 726);
            button4.Name = "button4";
            button4.Size = new Size(200, 46);
            button4.TabIndex = 16;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 809);
            Controls.Add(button4);
            Controls.Add(txtSaldo);
            Controls.Add(label8);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtMonto);
            Controls.Add(txtCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gestion de cuenta de ahorros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCliente;
        private TextBox txtMonto;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label8;
        private TextBox txtSaldo;
        private Button button4;
    }
}