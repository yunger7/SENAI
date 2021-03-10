namespace CircodeApps2
{
    partial class FrmIMC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblPeso = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(199, 52);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(199, 102);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Location = new System.Drawing.Point(13, 31);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(106, 13);
            this.LblPeso.TabIndex = 2;
            this.LblPeso.Text = "Digite o seu peso";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(16, 52);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(138, 20);
            this.TxtPeso.TabIndex = 1;
            this.TxtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeso_KeyPress);
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.Location = new System.Drawing.Point(13, 94);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(111, 13);
            this.LblAltura.TabIndex = 4;
            this.LblAltura.Text = "Digite a sua altura";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(13, 148);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(79, 16);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "Resultado";
            // 
            // LblMostrar
            // 
            this.LblMostrar.AutoSize = true;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.Location = new System.Drawing.Point(13, 191);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(0, 33);
            this.LblMostrar.TabIndex = 6;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(16, 110);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(138, 20);
            this.TxtAltura.TabIndex = 2;
            this.TxtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAltura_KeyPress);
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 281);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo do IMC";
            this.Load += new System.EventHandler(this.FrmIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.TextBox TxtAltura;
    }
}