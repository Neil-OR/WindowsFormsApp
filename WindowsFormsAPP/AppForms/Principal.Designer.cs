namespace AppForms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMICadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIArquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIArquivo
            // 
            this.TSMIArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMICadastroFuncionario,
            this.TSMIAgenda,
            this.TSMISair});
            this.TSMIArquivo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TSMIArquivo.Name = "TSMIArquivo";
            this.TSMIArquivo.Size = new System.Drawing.Size(63, 20);
            this.TSMIArquivo.Text = "Arquivo";
            // 
            // TSMICadastroFuncionario
            // 
            this.TSMICadastroFuncionario.Name = "TSMICadastroFuncionario";
            this.TSMICadastroFuncionario.Size = new System.Drawing.Size(195, 22);
            this.TSMICadastroFuncionario.Text = "Cadastro Funcionario";
            this.TSMICadastroFuncionario.Click += new System.EventHandler(this.TSMICadastroFuncionario_Click);
            // 
            // TSMIAgenda
            // 
            this.TSMIAgenda.Name = "TSMIAgenda";
            this.TSMIAgenda.Size = new System.Drawing.Size(195, 22);
            this.TSMIAgenda.Text = "Agenda";
            this.TSMIAgenda.Click += new System.EventHandler(this.TSMIAgenda_Click);
            // 
            // TSMISair
            // 
            this.TSMISair.Name = "TSMISair";
            this.TSMISair.Size = new System.Drawing.Size(195, 22);
            this.TSMISair.Text = "Sair";
            this.TSMISair.Click += new System.EventHandler(this.TSMISair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(447, 310);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIArquivo;
        private System.Windows.Forms.ToolStripMenuItem TSMICadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem TSMIAgenda;
        private System.Windows.Forms.ToolStripMenuItem TSMISair;
    }
}

