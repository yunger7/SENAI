namespace CircodeApps2
{
    partial class FrmEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmprestimo));
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.GrbResposta = new System.Windows.Forms.GroupBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtJuros = new System.Windows.Forms.TextBox();
            this.LblJuros = new System.Windows.Forms.Label();
            this.TxtPrazo = new System.Windows.Forms.TextBox();
            this.LblPrazo = new System.Windows.Forms.Label();
            this.TxtJurosPagos = new System.Windows.Forms.TextBox();
            this.LblJurosPagos = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtPagamentoMensal = new System.Windows.Forms.TextBox();
            this.LblMensal = new System.Windows.Forms.Label();
            this.GrbResposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(12, 9);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(122, 13);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Valor do Empréstimo";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(12, 25);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(122, 20);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(313, 37);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // GrbResposta
            // 
            this.GrbResposta.Controls.Add(this.TxtJurosPagos);
            this.GrbResposta.Controls.Add(this.LblMensal);
            this.GrbResposta.Controls.Add(this.LblJurosPagos);
            this.GrbResposta.Controls.Add(this.TxtPagamentoMensal);
            this.GrbResposta.Controls.Add(this.TxtTotal);
            this.GrbResposta.Controls.Add(this.LblTotal);
            this.GrbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbResposta.Location = new System.Drawing.Point(141, 12);
            this.GrbResposta.Name = "GrbResposta";
            this.GrbResposta.Size = new System.Drawing.Size(147, 191);
            this.GrbResposta.TabIndex = 3;
            this.GrbResposta.TabStop = false;
            this.GrbResposta.Text = "Demonstrativo";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(313, 86);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtJuros
            // 
            this.TxtJuros.Location = new System.Drawing.Point(12, 77);
            this.TxtJuros.Name = "TxtJuros";
            this.TxtJuros.Size = new System.Drawing.Size(122, 20);
            this.TxtJuros.TabIndex = 6;
            this.TxtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJuros_KeyPress);
            // 
            // LblJuros
            // 
            this.LblJuros.AutoSize = true;
            this.LblJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJuros.Location = new System.Drawing.Point(12, 61);
            this.LblJuros.Name = "LblJuros";
            this.LblJuros.Size = new System.Drawing.Size(58, 13);
            this.LblJuros.TabIndex = 5;
            this.LblJuros.Text = "Juros (%)";
            // 
            // TxtPrazo
            // 
            this.TxtPrazo.Location = new System.Drawing.Point(12, 133);
            this.TxtPrazo.Name = "TxtPrazo";
            this.TxtPrazo.Size = new System.Drawing.Size(122, 20);
            this.TxtPrazo.TabIndex = 8;
            this.TxtPrazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrazo_KeyPress);
            // 
            // LblPrazo
            // 
            this.LblPrazo.AutoSize = true;
            this.LblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrazo.Location = new System.Drawing.Point(12, 117);
            this.LblPrazo.Name = "LblPrazo";
            this.LblPrazo.Size = new System.Drawing.Size(78, 13);
            this.LblPrazo.TabIndex = 7;
            this.LblPrazo.Text = "Prazo (anos)";
            // 
            // TxtJurosPagos
            // 
            this.TxtJurosPagos.Location = new System.Drawing.Point(16, 160);
            this.TxtJurosPagos.Name = "TxtJurosPagos";
            this.TxtJurosPagos.Size = new System.Drawing.Size(114, 20);
            this.TxtJurosPagos.TabIndex = 14;
            // 
            // LblJurosPagos
            // 
            this.LblJurosPagos.AutoSize = true;
            this.LblJurosPagos.Location = new System.Drawing.Point(16, 144);
            this.LblJurosPagos.Name = "LblJurosPagos";
            this.LblJurosPagos.Size = new System.Drawing.Size(76, 13);
            this.LblJurosPagos.TabIndex = 13;
            this.LblJurosPagos.Text = "Juros Pagos";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(16, 104);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(114, 20);
            this.TxtTotal.TabIndex = 12;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(16, 88);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(69, 13);
            this.LblTotal.TabIndex = 11;
            this.LblTotal.Text = "Total Pago";
            // 
            // TxtPagamentoMensal
            // 
            this.TxtPagamentoMensal.Location = new System.Drawing.Point(16, 52);
            this.TxtPagamentoMensal.Name = "TxtPagamentoMensal";
            this.TxtPagamentoMensal.Size = new System.Drawing.Size(114, 20);
            this.TxtPagamentoMensal.TabIndex = 10;
            // 
            // LblMensal
            // 
            this.LblMensal.AutoSize = true;
            this.LblMensal.Location = new System.Drawing.Point(16, 36);
            this.LblMensal.Name = "LblMensal";
            this.LblMensal.Size = new System.Drawing.Size(114, 13);
            this.LblMensal.TabIndex = 9;
            this.LblMensal.Text = "Pagamento Mensal";
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 230);
            this.Controls.Add(this.TxtPrazo);
            this.Controls.Add(this.LblPrazo);
            this.Controls.Add(this.TxtJuros);
            this.Controls.Add(this.LblJuros);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GrbResposta);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Empréstimo";
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.GrbResposta.ResumeLayout(false);
            this.GrbResposta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.GroupBox GrbResposta;
        private System.Windows.Forms.TextBox TxtJurosPagos;
        private System.Windows.Forms.Label LblMensal;
        private System.Windows.Forms.Label LblJurosPagos;
        private System.Windows.Forms.TextBox TxtPagamentoMensal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtJuros;
        private System.Windows.Forms.Label LblJuros;
        private System.Windows.Forms.TextBox TxtPrazo;
        private System.Windows.Forms.Label LblPrazo;
    }
}