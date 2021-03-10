
namespace APP1
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(25, 31);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(113, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = " Digite o seu nome";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(25, 83);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(222, 44);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "&Mostrar";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(222, 92);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "&Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(28, 47);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(110, 20);
            this.textName.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 157);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNome);
            this.Name = "mainForm";
            this.Text = "Meu 1º Aplicativo";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textName;
    }
}

