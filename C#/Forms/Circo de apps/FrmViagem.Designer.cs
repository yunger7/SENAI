namespace CircodeApps2
{
    partial class FrmViagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViagem));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblAutonomia = new System.Windows.Forms.Label();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblMostrarLitros = new System.Windows.Forms.Label();
            this.LblGastos = new System.Windows.Forms.Label();
            this.TxtAutonomia = new System.Windows.Forms.TextBox();
            this.TxtCombustivel = new System.Windows.Forms.TextBox();
            this.TxtDistancia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(208, 29);
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
            this.BtnSair.Location = new System.Drawing.Point(208, 84);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblAutonomia
            // 
            this.LblAutonomia.AutoSize = true;
            this.LblAutonomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutonomia.Location = new System.Drawing.Point(13, 13);
            this.LblAutonomia.Name = "LblAutonomia";
            this.LblAutonomia.Size = new System.Drawing.Size(104, 13);
            this.LblAutonomia.TabIndex = 2;
            this.LblAutonomia.Text = "Autonomia (Km/l)";
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreco.Location = new System.Drawing.Point(12, 71);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(173, 13);
            this.LblPreco.TabIndex = 3;
            this.LblPreco.Text = "Preço do Combustível (R$/L)";
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistancia.Location = new System.Drawing.Point(12, 132);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(155, 13);
            this.LblDistancia.TabIndex = 4;
            this.LblDistancia.Text = "Distância a percorrer (Km)";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(13, 197);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(64, 13);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "Resultado";
            // 
            // LblMostrarLitros
            // 
            this.LblMostrarLitros.AutoSize = true;
            this.LblMostrarLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarLitros.Location = new System.Drawing.Point(13, 234);
            this.LblMostrarLitros.Name = "LblMostrarLitros";
            this.LblMostrarLitros.Size = new System.Drawing.Size(0, 24);
            this.LblMostrarLitros.TabIndex = 6;
            // 
            // LblGastos
            // 
            this.LblGastos.AutoSize = true;
            this.LblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastos.Location = new System.Drawing.Point(9, 276);
            this.LblGastos.Name = "LblGastos";
            this.LblGastos.Size = new System.Drawing.Size(0, 24);
            this.LblGastos.TabIndex = 7;
            // 
            // TxtAutonomia
            // 
            this.TxtAutonomia.Location = new System.Drawing.Point(12, 29);
            this.TxtAutonomia.Name = "TxtAutonomia";
            this.TxtAutonomia.Size = new System.Drawing.Size(177, 20);
            this.TxtAutonomia.TabIndex = 8;
            this.TxtAutonomia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAutonomia_KeyPress);
            // 
            // TxtCombustivel
            // 
            this.TxtCombustivel.Location = new System.Drawing.Point(12, 87);
            this.TxtCombustivel.Name = "TxtCombustivel";
            this.TxtCombustivel.Size = new System.Drawing.Size(177, 20);
            this.TxtCombustivel.TabIndex = 9;
            this.TxtCombustivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCombustivel_KeyPress);
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.Location = new System.Drawing.Point(12, 148);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(177, 20);
            this.TxtDistancia.TabIndex = 10;
            this.TxtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDistancia_KeyPress);
            // 
            // FrmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 313);
            this.Controls.Add(this.TxtDistancia);
            this.Controls.Add(this.TxtCombustivel);
            this.Controls.Add(this.TxtAutonomia);
            this.Controls.Add(this.LblGastos);
            this.Controls.Add(this.LblMostrarLitros);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblAutonomia);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo da Viagem";
            this.Load += new System.EventHandler(this.FrmViagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblAutonomia;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblMostrarLitros;
        private System.Windows.Forms.Label LblGastos;
        private System.Windows.Forms.TextBox TxtAutonomia;
        private System.Windows.Forms.TextBox TxtCombustivel;
        private System.Windows.Forms.TextBox TxtDistancia;
    }
}