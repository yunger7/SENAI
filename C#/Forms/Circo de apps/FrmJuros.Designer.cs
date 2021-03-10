namespace CircodeApps2
{
    partial class FrmJuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuros));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblMontante = new System.Windows.Forms.Label();
            this.TxtMontante = new System.Windows.Forms.TextBox();
            this.LtBParcelas = new System.Windows.Forms.ListBox();
            this.TxtTaxa = new System.Windows.Forms.TextBox();
            this.LblTaxa = new System.Windows.Forms.Label();
            this.TxtTempo = new System.Windows.Forms.TextBox();
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblParcelas = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblMostrarTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(585, 39);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblMontante
            // 
            this.LblMontante.AutoSize = true;
            this.LblMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontante.Location = new System.Drawing.Point(12, 23);
            this.LblMontante.Name = "LblMontante";
            this.LblMontante.Size = new System.Drawing.Size(89, 13);
            this.LblMontante.TabIndex = 1;
            this.LblMontante.Text = "Valor Principal";
            // 
            // TxtMontante
            // 
            this.TxtMontante.Location = new System.Drawing.Point(12, 39);
            this.TxtMontante.Name = "TxtMontante";
            this.TxtMontante.Size = new System.Drawing.Size(140, 20);
            this.TxtMontante.TabIndex = 2;
            this.TxtMontante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontante_KeyPress);
            // 
            // LtBParcelas
            // 
            this.LtBParcelas.FormattingEnabled = true;
            this.LtBParcelas.Location = new System.Drawing.Point(173, 39);
            this.LtBParcelas.Name = "LtBParcelas";
            this.LtBParcelas.Size = new System.Drawing.Size(372, 147);
            this.LtBParcelas.TabIndex = 3;
            // 
            // TxtTaxa
            // 
            this.TxtTaxa.Location = new System.Drawing.Point(12, 89);
            this.TxtTaxa.Name = "TxtTaxa";
            this.TxtTaxa.Size = new System.Drawing.Size(140, 20);
            this.TxtTaxa.TabIndex = 5;
            this.TxtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxa_KeyPress);
            // 
            // LblTaxa
            // 
            this.LblTaxa.AutoSize = true;
            this.LblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaxa.Location = new System.Drawing.Point(12, 73);
            this.LblTaxa.Name = "LblTaxa";
            this.LblTaxa.Size = new System.Drawing.Size(56, 13);
            this.LblTaxa.TabIndex = 4;
            this.LblTaxa.Text = "Taxa (%)";
            // 
            // TxtTempo
            // 
            this.TxtTempo.Location = new System.Drawing.Point(12, 146);
            this.TxtTempo.Name = "TxtTempo";
            this.TxtTempo.Size = new System.Drawing.Size(140, 20);
            this.TxtTempo.TabIndex = 7;
            this.TxtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTempo_KeyPress);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.Location = new System.Drawing.Point(12, 130);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(45, 13);
            this.LblTempo.TabIndex = 6;
            this.LblTempo.Text = "Tempo";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(585, 87);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblParcelas
            // 
            this.LblParcelas.AutoSize = true;
            this.LblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParcelas.Location = new System.Drawing.Point(170, 23);
            this.LblParcelas.Name = "LblParcelas";
            this.LblParcelas.Size = new System.Drawing.Size(56, 13);
            this.LblParcelas.TabIndex = 9;
            this.LblParcelas.Text = "Parcelas";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(184, 201);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(36, 13);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total";
            // 
            // LblMostrarTotal
            // 
            this.LblMostrarTotal.AutoSize = true;
            this.LblMostrarTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarTotal.Location = new System.Drawing.Point(184, 225);
            this.LblMostrarTotal.Name = "LblMostrarTotal";
            this.LblMostrarTotal.Size = new System.Drawing.Size(0, 20);
            this.LblMostrarTotal.TabIndex = 11;
            // 
            // FrmJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 258);
            this.Controls.Add(this.LblMostrarTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblParcelas);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtTempo);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.TxtTaxa);
            this.Controls.Add(this.LblTaxa);
            this.Controls.Add(this.LtBParcelas);
            this.Controls.Add(this.TxtMontante);
            this.Controls.Add(this.LblMontante);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJuros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Juros Compostos";
            this.Load += new System.EventHandler(this.FrmJuros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblMontante;
        private System.Windows.Forms.TextBox TxtMontante;
        private System.Windows.Forms.ListBox LtBParcelas;
        private System.Windows.Forms.TextBox TxtTaxa;
        private System.Windows.Forms.Label LblTaxa;
        private System.Windows.Forms.TextBox TxtTempo;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblParcelas;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblMostrarTotal;
    }
}