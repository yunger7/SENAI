namespace CircodeApps2
{
    partial class FrmMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoeda));
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblDolar = new System.Windows.Forms.Label();
            this.LblMostrarDolar = new System.Windows.Forms.Label();
            this.LblMostrarEuro = new System.Windows.Forms.Label();
            this.LblEuro = new System.Windows.Forms.Label();
            this.LblMostrarFranco = new System.Windows.Forms.Label();
            this.LblFranco = new System.Windows.Forms.Label();
            this.LblMostrarIen = new System.Windows.Forms.Label();
            this.LblIen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(13, 13);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(132, 13);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Digite um valor em R$";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(13, 30);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(167, 20);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // BtnConverter
            // 
            this.BtnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverter.Location = new System.Drawing.Point(219, 28);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(75, 23);
            this.BtnConverter.TabIndex = 2;
            this.BtnConverter.Text = "Converter";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(219, 76);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblDolar
            // 
            this.LblDolar.AutoSize = true;
            this.LblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDolar.Location = new System.Drawing.Point(19, 100);
            this.LblDolar.Name = "LblDolar";
            this.LblDolar.Size = new System.Drawing.Size(37, 13);
            this.LblDolar.TabIndex = 4;
            this.LblDolar.Text = "Dólar";
            // 
            // LblMostrarDolar
            // 
            this.LblMostrarDolar.AutoSize = true;
            this.LblMostrarDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarDolar.Location = new System.Drawing.Point(19, 126);
            this.LblMostrarDolar.Name = "LblMostrarDolar";
            this.LblMostrarDolar.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarDolar.TabIndex = 5;
            // 
            // LblMostrarEuro
            // 
            this.LblMostrarEuro.AutoSize = true;
            this.LblMostrarEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarEuro.Location = new System.Drawing.Point(19, 183);
            this.LblMostrarEuro.Name = "LblMostrarEuro";
            this.LblMostrarEuro.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarEuro.TabIndex = 7;
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEuro.Location = new System.Drawing.Point(19, 157);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(33, 13);
            this.LblEuro.TabIndex = 6;
            this.LblEuro.Text = "Euro";
            // 
            // LblMostrarFranco
            // 
            this.LblMostrarFranco.AutoSize = true;
            this.LblMostrarFranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarFranco.Location = new System.Drawing.Point(19, 239);
            this.LblMostrarFranco.Name = "LblMostrarFranco";
            this.LblMostrarFranco.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarFranco.TabIndex = 9;
            // 
            // LblFranco
            // 
            this.LblFranco.AutoSize = true;
            this.LblFranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFranco.Location = new System.Drawing.Point(19, 213);
            this.LblFranco.Name = "LblFranco";
            this.LblFranco.Size = new System.Drawing.Size(46, 13);
            this.LblFranco.TabIndex = 8;
            this.LblFranco.Text = "Franco";
            // 
            // LblMostrarIen
            // 
            this.LblMostrarIen.AutoSize = true;
            this.LblMostrarIen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarIen.Location = new System.Drawing.Point(19, 291);
            this.LblMostrarIen.Name = "LblMostrarIen";
            this.LblMostrarIen.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarIen.TabIndex = 11;
            // 
            // LblIen
            // 
            this.LblIen.AutoSize = true;
            this.LblIen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIen.Location = new System.Drawing.Point(19, 265);
            this.LblIen.Name = "LblIen";
            this.LblIen.Size = new System.Drawing.Size(32, 13);
            this.LblIen.TabIndex = 10;
            this.LblIen.Text = "Iene";
            // 
            // FrmMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 316);
            this.Controls.Add(this.LblMostrarIen);
            this.Controls.Add(this.LblIen);
            this.Controls.Add(this.LblMostrarFranco);
            this.Controls.Add(this.LblFranco);
            this.Controls.Add(this.LblMostrarEuro);
            this.Controls.Add(this.LblEuro);
            this.Controls.Add(this.LblMostrarDolar);
            this.Controls.Add(this.LblDolar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnConverter);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Moedas";
            this.Load += new System.EventHandler(this.FrmMoeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblDolar;
        private System.Windows.Forms.Label LblMostrarDolar;
        private System.Windows.Forms.Label LblMostrarEuro;
        private System.Windows.Forms.Label LblEuro;
        private System.Windows.Forms.Label LblMostrarFranco;
        private System.Windows.Forms.Label LblFranco;
        private System.Windows.Forms.Label LblMostrarIen;
        private System.Windows.Forms.Label LblIen;
    }
}