namespace PDFDemo
{
    partial class MainForm
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
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(12, 25);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(200, 20);
            this.txtDiretorio.TabIndex = 0;
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Location = new System.Drawing.Point(12, 9);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(46, 13);
            this.lblDiretorio.TabIndex = 1;
            this.lblDiretorio.Text = "Diretório";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(218, 24);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(26, 21);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 64);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(600, 216);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 286);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(600, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(412, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(200, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(409, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(91, 13);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "Nome Do Arquivo";
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Location = new System.Drawing.Point(12, 48);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(56, 13);
            this.lblConteudo.TabIndex = 7;
            this.lblConteudo.Text = "Conteúdo:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblDiretorio);
            this.Controls.Add(this.txtDiretorio);
            this.Name = "MainForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblConteudo;
    }
}

