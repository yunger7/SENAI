namespace CircodeApps2
{
    partial class FrmData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmData));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblInicial = new System.Windows.Forms.Label();
            this.LblFinal = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.MaskInicial = new System.Windows.Forms.MaskedTextBox();
            this.MaskFinal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(181, 26);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(181, 81);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblInicial
            // 
            this.LblInicial.AutoSize = true;
            this.LblInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicial.Location = new System.Drawing.Point(13, 13);
            this.LblInicial.Name = "LblInicial";
            this.LblInicial.Size = new System.Drawing.Size(72, 13);
            this.LblInicial.TabIndex = 2;
            this.LblInicial.Text = "Data Inicial";
            // 
            // LblFinal
            // 
            this.LblFinal.AutoSize = true;
            this.LblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinal.Location = new System.Drawing.Point(12, 65);
            this.LblFinal.Name = "LblFinal";
            this.LblFinal.Size = new System.Drawing.Size(65, 13);
            this.LblFinal.TabIndex = 3;
            this.LblFinal.Text = "Data Final";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(13, 142);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(64, 13);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.Text = "Resultado";
            // 
            // LblMostrar
            // 
            this.LblMostrar.AutoSize = true;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.Location = new System.Drawing.Point(13, 184);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(0, 33);
            this.LblMostrar.TabIndex = 5;
            // 
            // MaskInicial
            // 
            this.MaskInicial.Location = new System.Drawing.Point(12, 29);
            this.MaskInicial.Mask = "00/00/0000";
            this.MaskInicial.Name = "MaskInicial";
            this.MaskInicial.Size = new System.Drawing.Size(100, 20);
            this.MaskInicial.TabIndex = 6;
            this.MaskInicial.ValidatingType = typeof(System.DateTime);
            // 
            // MaskFinal
            // 
            this.MaskFinal.Location = new System.Drawing.Point(12, 81);
            this.MaskFinal.Mask = "00/00/0000";
            this.MaskFinal.Name = "MaskFinal";
            this.MaskFinal.Size = new System.Drawing.Size(100, 20);
            this.MaskFinal.TabIndex = 7;
            this.MaskFinal.ValidatingType = typeof(System.DateTime);
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 266);
            this.Controls.Add(this.MaskFinal);
            this.Controls.Add(this.MaskInicial);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblFinal);
            this.Controls.Add(this.LblInicial);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo da Diferença entre Datas";
            this.Load += new System.EventHandler(this.FrmData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblInicial;
        private System.Windows.Forms.Label LblFinal;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.MaskedTextBox MaskInicial;
        private System.Windows.Forms.MaskedTextBox MaskFinal;
    }
}