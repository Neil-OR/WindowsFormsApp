namespace AppForms
{
    partial class CadastroAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label LNome;
            System.Windows.Forms.Label LEndereco;
            System.Windows.Forms.Label LTelefone;
            System.Windows.Forms.Label LEmail;
            this.appFormsDataSet = new AppForms.AppFormsDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new AppForms.AppFormsDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new AppForms.AppFormsDataSetTableAdapters.TableAdapterManager();
            this.TBNome = new System.Windows.Forms.TextBox();
            this.TBEndereco = new System.Windows.Forms.TextBox();
            this.TBTelefone = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LVCasdastroAgenda = new System.Windows.Forms.ListView();
            this.CHNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            LNome = new System.Windows.Forms.Label();
            LEndereco = new System.Windows.Forms.Label();
            LTelefone = new System.Windows.Forms.Label();
            LEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appFormsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LNome
            // 
            LNome.AutoSize = true;
            LNome.Location = new System.Drawing.Point(95, 39);
            LNome.Name = "LNome";
            LNome.Size = new System.Drawing.Size(38, 13);
            LNome.TabIndex = 1;
            LNome.Text = "Nome:";
            // 
            // LEndereco
            // 
            LEndereco.AutoSize = true;
            LEndereco.Location = new System.Drawing.Point(76, 77);
            LEndereco.Name = "LEndereco";
            LEndereco.Size = new System.Drawing.Size(56, 13);
            LEndereco.TabIndex = 2;
            LEndereco.Text = "Endereço:";
            // 
            // LTelefone
            // 
            LTelefone.AutoSize = true;
            LTelefone.Location = new System.Drawing.Point(83, 115);
            LTelefone.Name = "LTelefone";
            LTelefone.Size = new System.Drawing.Size(52, 13);
            LTelefone.TabIndex = 4;
            LTelefone.Text = "Telefone:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new System.Drawing.Point(95, 153);
            LEmail.Name = "LEmail";
            LEmail.Size = new System.Drawing.Size(38, 13);
            LEmail.TabIndex = 6;
            LEmail.Text = "E-mail:";
            // 
            // appFormsDataSet
            // 
            this.appFormsDataSet.DataSetName = "AppFormsDataSet";
            this.appFormsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.appFormsDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppForms.AppFormsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TBNome
            // 
            this.TBNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "nome", true));
            this.TBNome.Location = new System.Drawing.Point(137, 36);
            this.TBNome.Name = "TBNome";
            this.TBNome.Size = new System.Drawing.Size(272, 20);
            this.TBNome.TabIndex = 2;
            // 
            // TBEndereco
            // 
            this.TBEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "endereco", true));
            this.TBEndereco.Location = new System.Drawing.Point(137, 74);
            this.TBEndereco.Name = "TBEndereco";
            this.TBEndereco.Size = new System.Drawing.Size(272, 20);
            this.TBEndereco.TabIndex = 3;
            // 
            // TBTelefone
            // 
            this.TBTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "telefone", true));
            this.TBTelefone.Location = new System.Drawing.Point(137, 112);
            this.TBTelefone.Name = "TBTelefone";
            this.TBTelefone.Size = new System.Drawing.Size(272, 20);
            this.TBTelefone.TabIndex = 5;
            // 
            // TBEmail
            // 
            this.TBEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "email", true));
            this.TBEmail.Location = new System.Drawing.Point(137, 150);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(272, 20);
            this.TBEmail.TabIndex = 7;
            // 
            // LVCasdastroAgenda
            // 
            this.LVCasdastroAgenda.BackColor = System.Drawing.SystemColors.Window;
            this.LVCasdastroAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHNome,
            this.CHEndereco,
            this.CHTelefone,
            this.CHEmail});
            this.LVCasdastroAgenda.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LVCasdastroAgenda.FullRowSelect = true;
            this.LVCasdastroAgenda.GridLines = true;
            this.LVCasdastroAgenda.HideSelection = false;
            this.LVCasdastroAgenda.Location = new System.Drawing.Point(25, 215);
            this.LVCasdastroAgenda.Name = "LVCasdastroAgenda";
            this.LVCasdastroAgenda.Size = new System.Drawing.Size(613, 97);
            this.LVCasdastroAgenda.TabIndex = 8;
            this.LVCasdastroAgenda.UseCompatibleStateImageBehavior = false;
            this.LVCasdastroAgenda.View = System.Windows.Forms.View.Details;
            // 
            // CHNome
            // 
            this.CHNome.Text = "Nome";
            this.CHNome.Width = 174;
            // 
            // CHEndereco
            // 
            this.CHEndereco.Text = "Endereço";
            this.CHEndereco.Width = 126;
            // 
            // CHTelefone
            // 
            this.CHTelefone.Text = "Telefone";
            this.CHTelefone.Width = 93;
            // 
            // CHEmail
            // 
            this.CHEmail.Text = "E-mail";
            this.CHEmail.Width = 216;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(442, 36);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(46, 58);
            this.BtnNovo.TabIndex = 9;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(442, 112);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(46, 58);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(509, 36);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(46, 58);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(509, 112);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(46, 58);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // CadastroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 339);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LVCasdastroAgenda);
            this.Controls.Add(LEmail);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(LTelefone);
            this.Controls.Add(this.TBTelefone);
            this.Controls.Add(LEndereco);
            this.Controls.Add(this.TBEndereco);
            this.Controls.Add(LNome);
            this.Controls.Add(this.TBNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Agenda";
            this.Load += new System.EventHandler(this.CadastroAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appFormsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppFormsDataSet appFormsDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private AppFormsDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private AppFormsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox TBNome;
        private System.Windows.Forms.TextBox TBEndereco;
        private System.Windows.Forms.TextBox TBTelefone;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.ListView LVCasdastroAgenda;
        private System.Windows.Forms.ColumnHeader CHNome;
        private System.Windows.Forms.ColumnHeader CHEndereco;
        private System.Windows.Forms.ColumnHeader CHTelefone;
        private System.Windows.Forms.ColumnHeader CHEmail;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
    }
}