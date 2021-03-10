namespace CircodeApps2
{
    partial class FrmMega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMega));
            this.BtnSortear = new System.Windows.Forms.Button();
            this.LblNumeros = new System.Windows.Forms.Label();
            this.LbNumeros = new System.Windows.Forms.ListBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSortear
            // 
            this.BtnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSortear.Location = new System.Drawing.Point(160, 32);
            this.BtnSortear.Name = "BtnSortear";
            this.BtnSortear.Size = new System.Drawing.Size(75, 23);
            this.BtnSortear.TabIndex = 0;
            this.BtnSortear.Text = "Sortear";
            this.BtnSortear.UseVisualStyleBackColor = true;
            this.BtnSortear.Click += new System.EventHandler(this.BtnSortear_Click);
            // 
            // LblNumeros
            // 
            this.LblNumeros.AutoSize = true;
            this.LblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeros.Location = new System.Drawing.Point(13, 13);
            this.LblNumeros.Name = "LblNumeros";
            this.LblNumeros.Size = new System.Drawing.Size(117, 13);
            this.LblNumeros.TabIndex = 1;
            this.LblNumeros.Text = "Números Sorteados";
            // 
            // LbNumeros
            // 
            this.LbNumeros.FormattingEnabled = true;
            this.LbNumeros.Location = new System.Drawing.Point(16, 32);
            this.LbNumeros.Name = "LbNumeros";
            this.LbNumeros.Size = new System.Drawing.Size(120, 147);
            this.LbNumeros.TabIndex = 2;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(160, 79);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmMega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 226);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LbNumeros);
            this.Controls.Add(this.LblNumeros);
            this.Controls.Add(this.BtnSortear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Números da MegaSena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSortear;
        private System.Windows.Forms.Label LblNumeros;
        private System.Windows.Forms.ListBox LbNumeros;
        private System.Windows.Forms.Button BtnSair;
    }
}