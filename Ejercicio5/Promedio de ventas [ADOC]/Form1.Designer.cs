namespace Promedio_de_ventas__ADOC_
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            Boton1 = new Button();
            boton2 = new Button();
            boton3 = new Button();
            result = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 82);
            label1.Name = "label1";
            label1.Size = new Size(238, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el valor de la primer venta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 152);
            label2.Name = "label2";
            label2.Size = new Size(250, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el valor de la segunda venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 216);
            label3.Name = "label3";
            label3.Size = new Size(232, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el valor de la tercer venta:";
            // 
            // txt1
            // 
            txt1.Location = new Point(307, 82);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 3;
            // 
            // txt2
            // 
            txt2.Location = new Point(307, 149);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 27);
            txt2.TabIndex = 4;
            // 
            // txt3
            // 
            txt3.Location = new Point(307, 213);
            txt3.Name = "txt3";
            txt3.Size = new Size(125, 27);
            txt3.TabIndex = 5;
            // 
            // Boton1
            // 
            Boton1.BackColor = Color.Lime;
            Boton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Boton1.ForeColor = SystemColors.MenuText;
            Boton1.Location = new Point(30, 294);
            Boton1.Name = "Boton1";
            Boton1.Size = new Size(105, 45);
            Boton1.TabIndex = 6;
            Boton1.Text = "Calcular";
            Boton1.UseVisualStyleBackColor = false;
            Boton1.Click += Boton1_Click;
            // 
            // boton2
            // 
            boton2.BackColor = Color.Red;
            boton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            boton2.Location = new Point(215, 294);
            boton2.Name = "boton2";
            boton2.Size = new Size(105, 45);
            boton2.TabIndex = 7;
            boton2.Text = "Borrar";
            boton2.UseVisualStyleBackColor = false;
            boton2.Click += boton2_Click;
            // 
            // boton3
            // 
            boton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            boton3.Location = new Point(677, 12);
            boton3.Name = "boton3";
            boton3.Size = new Size(105, 45);
            boton3.TabIndex = 8;
            boton3.Text = "Regresar";
            boton3.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            result.Enabled = false;
            result.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            result.ForeColor = Color.White;
            result.Location = new Point(532, 145);
            result.Name = "result";
            result.Size = new Size(209, 32);
            result.TabIndex = 9;
            result.TextChanged += result_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(549, 190);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 10;
            label4.Text = "Promedio de las ventas";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 216);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 11;
            label5.Text = "$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 152);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 12;
            label6.Text = "$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 85);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 13;
            label7.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(307, 15);
            label8.Name = "label8";
            label8.Size = new Size(176, 32);
            label8.TabIndex = 14;
            label8.Text = "VENTAS ADOC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(result);
            Controls.Add(boton3);
            Controls.Add(boton2);
            Controls.Add(Boton1);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promedios [ADOC]";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Button Boton1;
        private Button boton2;
        private Button boton3;
        private TextBox result;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
