namespace Ejercicio1
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            tbMonto = new TextBox();
            tbDNI = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbNombre = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbMonto);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Nombres";
            // 
            // button1
            // 
            button1.Location = new Point(513, 81);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 1;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(198, 126);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(159, 23);
            tbMonto.TabIndex = 2;
            tbMonto.TextChanged += tbMonto_TextChanged;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(198, 88);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(159, 23);
            tbDNI.TabIndex = 3;
            tbDNI.TextChanged += tbDNI_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 129);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(198, 50);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(159, 23);
            tbNombre.TabIndex = 1;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 88);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "DNI";
            // 
            // button2
            // 
            button2.Location = new Point(32, 235);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 1;
            button2.Text = "Calcular Monto Total";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(32, 280);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 2;
            button3.Text = "Ver Monto Mayor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 324);
            button4.Name = "button4";
            button4.Size = new Size(125, 23);
            button4.TabIndex = 3;
            button4.Text = "Ver Ingresados";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 239);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 284);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 328);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // button5
            // 
            button5.Location = new Point(257, 367);
            button5.Name = "button5";
            button5.Size = new Size(289, 45);
            button5.TabIndex = 7;
            button5.Text = "Ver Expedientes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox tbNombre;
        private Button button1;
        private TextBox tbMonto;
        private TextBox tbDNI;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button5;
    }
}
