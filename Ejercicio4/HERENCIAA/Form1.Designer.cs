namespace HERENCIAA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHerencia = new System.Windows.Forms.Label();
            this.txtHerencia = new System.Windows.Forms.TextBox();
            this.txtJuan = new System.Windows.Forms.TextBox();
            this.lblJuan = new System.Windows.Forms.Label();
            this.txtLuis = new System.Windows.Forms.TextBox();
            this.lblLuis = new System.Windows.Forms.Label();
            this.txtRosa = new System.Windows.Forms.TextBox();
            this.lblRosa = new System.Windows.Forms.Label();
            this.txtAbogado = new System.Windows.Forms.TextBox();
            this.lblAbogado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHerencia
            // 
            this.lblHerencia.AutoSize = true;
            this.lblHerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerencia.Location = new System.Drawing.Point(138, 163);
            this.lblHerencia.Name = "lblHerencia";
            this.lblHerencia.Size = new System.Drawing.Size(70, 16);
            this.lblHerencia.TabIndex = 0;
            this.lblHerencia.Text = "Herencia";
            // 
            // txtHerencia
            // 
            this.txtHerencia.Location = new System.Drawing.Point(223, 162);
            this.txtHerencia.Name = "txtHerencia";
            this.txtHerencia.Size = new System.Drawing.Size(100, 20);
            this.txtHerencia.TabIndex = 1;
            // 
            // txtJuan
            // 
            this.txtJuan.Enabled = false;
            this.txtJuan.Location = new System.Drawing.Point(469, 68);
            this.txtJuan.Name = "txtJuan";
            this.txtJuan.Size = new System.Drawing.Size(100, 20);
            this.txtJuan.TabIndex = 3;
            // 
            // lblJuan
            // 
            this.lblJuan.AutoSize = true;
            this.lblJuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuan.Location = new System.Drawing.Point(382, 68);
            this.lblJuan.Name = "lblJuan";
            this.lblJuan.Size = new System.Drawing.Size(40, 16);
            this.lblJuan.TabIndex = 2;
            this.lblJuan.Text = "Juan";
            // 
            // txtLuis
            // 
            this.txtLuis.Enabled = false;
            this.txtLuis.Location = new System.Drawing.Point(469, 142);
            this.txtLuis.Name = "txtLuis";
            this.txtLuis.Size = new System.Drawing.Size(100, 20);
            this.txtLuis.TabIndex = 5;
            // 
            // lblLuis
            // 
            this.lblLuis.AutoSize = true;
            this.lblLuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuis.Location = new System.Drawing.Point(382, 142);
            this.lblLuis.Name = "lblLuis";
            this.lblLuis.Size = new System.Drawing.Size(35, 16);
            this.lblLuis.TabIndex = 4;
            this.lblLuis.Text = "Luis";
            // 
            // txtRosa
            // 
            this.txtRosa.Enabled = false;
            this.txtRosa.Location = new System.Drawing.Point(469, 212);
            this.txtRosa.Name = "txtRosa";
            this.txtRosa.Size = new System.Drawing.Size(100, 20);
            this.txtRosa.TabIndex = 7;
            // 
            // lblRosa
            // 
            this.lblRosa.AutoSize = true;
            this.lblRosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosa.Location = new System.Drawing.Point(382, 212);
            this.lblRosa.Name = "lblRosa";
            this.lblRosa.Size = new System.Drawing.Size(44, 16);
            this.lblRosa.TabIndex = 6;
            this.lblRosa.Text = "Rosa";
            // 
            // txtAbogado
            // 
            this.txtAbogado.Enabled = false;
            this.txtAbogado.Location = new System.Drawing.Point(469, 286);
            this.txtAbogado.Name = "txtAbogado";
            this.txtAbogado.Size = new System.Drawing.Size(100, 20);
            this.txtAbogado.TabIndex = 9;
            // 
            // lblAbogado
            // 
            this.lblAbogado.AutoSize = true;
            this.lblAbogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbogado.Location = new System.Drawing.Point(382, 286);
            this.lblAbogado.Name = "lblAbogado";
            this.lblAbogado.Size = new System.Drawing.Size(71, 16);
            this.lblAbogado.TabIndex = 8;
            this.lblAbogado.Text = "Abogado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 344);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 36);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Cálcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(282, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAbogado);
            this.Controls.Add(this.lblAbogado);
            this.Controls.Add(this.txtRosa);
            this.Controls.Add(this.lblRosa);
            this.Controls.Add(this.txtLuis);
            this.Controls.Add(this.lblLuis);
            this.Controls.Add(this.txtJuan);
            this.Controls.Add(this.lblJuan);
            this.Controls.Add(this.txtHerencia);
            this.Controls.Add(this.lblHerencia);
            this.Name = "Form1";
            this.Text = "CALCULO DE HERENCIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHerencia;
        private System.Windows.Forms.TextBox txtHerencia;
        private System.Windows.Forms.TextBox txtJuan;
        private System.Windows.Forms.Label lblJuan;
        private System.Windows.Forms.TextBox txtLuis;
        private System.Windows.Forms.Label lblLuis;
        private System.Windows.Forms.TextBox txtRosa;
        private System.Windows.Forms.Label lblRosa;
        private System.Windows.Forms.TextBox txtAbogado;
        private System.Windows.Forms.Label lblAbogado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

