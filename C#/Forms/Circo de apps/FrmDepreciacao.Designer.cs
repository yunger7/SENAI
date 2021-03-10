namespace CircodeApps2
{
    partial class FrmDepreciacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepreciacao));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblPreco = new System.Windows.Forms.Label();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.LblAno = new System.Windows.Forms.Label();
            this.LblDAno = new System.Windows.Forms.Label();
            this.LblMostrarAno = new System.Windows.Forms.Label();
            this.LblDMensal = new System.Windows.Forms.Label();
            this.LblMostrarMensal = new System.Windows.Forms.Label();
            this.LblPrecoAtual = new System.Windows.Forms.Label();
            this.LblMostrarPreco = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(216, 29);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreco.Location = new System.Drawing.Point(13, 13);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(125, 13);
            this.LblPreco.TabIndex = 1;
            this.LblPreco.Text = "Preço do Veículo (0)";
            // 
            // TxtPreco
            // 
            this.TxtPreco.Location = new System.Drawing.Point(13, 31);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(159, 20);
            this.TxtPreco.TabIndex = 2;
            this.TxtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco_KeyPress);
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(12, 93);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(160, 20);
            this.TxtAno.TabIndex = 4;
            this.TxtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAno_KeyPress);
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAno.Location = new System.Drawing.Point(12, 75);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(95, 13);
            this.LblAno.TabIndex = 3;
            this.LblAno.Text = "Ano do Veículo";
            // 
            // LblDAno
            // 
            this.LblDAno.AutoSize = true;
            this.LblDAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAno.Location = new System.Drawing.Point(10, 143);
            this.LblDAno.Name = "LblDAno";
            this.LblDAno.Size = new System.Drawing.Size(115, 13);
            this.LblDAno.TabIndex = 5;
            this.LblDAno.Text = "Depreciação Anual";
            // 
            // LblMostrarAno
            // 
            this.LblMostrarAno.AutoSize = true;
            this.LblMostrarAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarAno.Location = new System.Drawing.Point(10, 172);
            this.LblMostrarAno.Name = "LblMostrarAno";
            this.LblMostrarAno.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarAno.TabIndex = 6;
            // 
            // LblDMensal
            // 
            this.LblDMensal.AutoSize = true;
            this.LblDMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDMensal.Location = new System.Drawing.Point(9, 199);
            this.LblDMensal.Name = "LblDMensal";
            this.LblDMensal.Size = new System.Drawing.Size(123, 13);
            this.LblDMensal.TabIndex = 7;
            this.LblDMensal.Text = "Depreciação Mensal";
            // 
            // LblMostrarMensal
            // 
            this.LblMostrarMensal.AutoSize = true;
            this.LblMostrarMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarMensal.Location = new System.Drawing.Point(9, 225);
            this.LblMostrarMensal.Name = "LblMostrarMensal";
            this.LblMostrarMensal.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarMensal.TabIndex = 8;
            // 
            // LblPrecoAtual
            // 
            this.LblPrecoAtual.AutoSize = true;
            this.LblPrecoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecoAtual.Location = new System.Drawing.Point(9, 252);
            this.LblPrecoAtual.Name = "LblPrecoAtual";
            this.LblPrecoAtual.Size = new System.Drawing.Size(138, 13);
            this.LblPrecoAtual.TabIndex = 9;
            this.LblPrecoAtual.Text = "Preço atual do Veículo";
            // 
            // LblMostrarPreco
            // 
            this.LblMostrarPreco.AutoSize = true;
            this.LblMostrarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarPreco.Location = new System.Drawing.Point(9, 276);
            this.LblMostrarPreco.Name = "LblMostrarPreco";
            this.LblMostrarPreco.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarPreco.TabIndex = 10;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(216, 75);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmDepreciacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 309);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblMostrarPreco);
            this.Controls.Add(this.LblPrecoAtual);
            this.Controls.Add(this.LblMostrarMensal);
            this.Controls.Add(this.LblDMensal);
            this.Controls.Add(this.LblMostrarAno);
            this.Controls.Add(this.LblDAno);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepreciacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depreciação de Veículos";
            this.Load += new System.EventHandler(this.FrmDepreciacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.Label LblDAno;
        private System.Windows.Forms.Label LblMostrarAno;
        private System.Windows.Forms.Label LblDMensal;
        private System.Windows.Forms.Label LblMostrarMensal;
        private System.Windows.Forms.Label LblPrecoAtual;
        private System.Windows.Forms.Label LblMostrarPreco;
        private System.Windows.Forms.Button BtnSair;
    }
}