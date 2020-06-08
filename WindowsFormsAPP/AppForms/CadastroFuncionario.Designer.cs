namespace AppForms
{
    partial class CadastroFuncionario
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
            System.Windows.Forms.Label LCargo;
            System.Windows.Forms.Label LCPF;
            System.Windows.Forms.Label LDescontoSalario;
            System.Windows.Forms.Label LSalarioBruto;
            System.Windows.Forms.Label LAdicionalSalario;
            System.Windows.Forms.Label LSalarioLiquido;
            this.LVCasdastroFuncionario = new System.Windows.Forms.ListView();
            this.CHNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHSalarioBruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHDescontoSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHAdicionalSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHSalarioLiquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBNome = new System.Windows.Forms.TextBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appFormsDataSet = new AppForms.AppFormsDataSet();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.TBCPF = new System.Windows.Forms.TextBox();
            this.TBDescontoSalario = new System.Windows.Forms.TextBox();
            this.TBSalarioBruto = new System.Windows.Forms.TextBox();
            this.TBAdicionalSalario = new System.Windows.Forms.TextBox();
            this.TBSalarioLiquido = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnOrdenarLista = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.CheckSemDesconto = new System.Windows.Forms.CheckBox();
            this.funcionarioTableAdapter = new AppForms.AppFormsDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new AppForms.AppFormsDataSetTableAdapters.TableAdapterManager();
            LNome = new System.Windows.Forms.Label();
            LCargo = new System.Windows.Forms.Label();
            LCPF = new System.Windows.Forms.Label();
            LDescontoSalario = new System.Windows.Forms.Label();
            LSalarioBruto = new System.Windows.Forms.Label();
            LAdicionalSalario = new System.Windows.Forms.Label();
            LSalarioLiquido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appFormsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LNome
            // 
            LNome.AutoSize = true;
            LNome.Location = new System.Drawing.Point(32, 28);
            LNome.Name = "LNome";
            LNome.Size = new System.Drawing.Size(38, 13);
            LNome.TabIndex = 2;
            LNome.Text = "Nome:";
            // 
            // LCargo
            // 
            LCargo.AutoSize = true;
            LCargo.Location = new System.Drawing.Point(362, 54);
            LCargo.Name = "LCargo";
            LCargo.Size = new System.Drawing.Size(37, 13);
            LCargo.TabIndex = 3;
            LCargo.Text = "cargo:";
            // 
            // LCPF
            // 
            LCPF.AutoSize = true;
            LCPF.Location = new System.Drawing.Point(40, 57);
            LCPF.Name = "LCPF";
            LCPF.Size = new System.Drawing.Size(30, 13);
            LCPF.TabIndex = 5;
            LCPF.Text = "CPF:";
            // 
            // LDescontoSalario
            // 
            LDescontoSalario.AutoSize = true;
            LDescontoSalario.Location = new System.Drawing.Point(14, 109);
            LDescontoSalario.Name = "LDescontoSalario";
            LDescontoSalario.Size = new System.Drawing.Size(56, 13);
            LDescontoSalario.TabIndex = 7;
            LDescontoSalario.Text = "Desconto:";
            // 
            // LSalarioBruto
            // 
            LSalarioBruto.AutoSize = true;
            LSalarioBruto.Location = new System.Drawing.Point(28, 83);
            LSalarioBruto.Name = "LSalarioBruto";
            LSalarioBruto.Size = new System.Drawing.Size(42, 13);
            LSalarioBruto.TabIndex = 9;
            LSalarioBruto.Text = "Salário:";
            // 
            // LAdicionalSalario
            // 
            LAdicionalSalario.AutoSize = true;
            LAdicionalSalario.Location = new System.Drawing.Point(17, 135);
            LAdicionalSalario.Name = "LAdicionalSalario";
            LAdicionalSalario.Size = new System.Drawing.Size(53, 13);
            LAdicionalSalario.TabIndex = 11;
            LAdicionalSalario.Text = "Adicional:";
            // 
            // LSalarioLiquido
            // 
            LSalarioLiquido.AutoSize = true;
            LSalarioLiquido.Location = new System.Drawing.Point(339, 135);
            LSalarioLiquido.Name = "LSalarioLiquido";
            LSalarioLiquido.Size = new System.Drawing.Size(81, 13);
            LSalarioLiquido.TabIndex = 13;
            LSalarioLiquido.Text = "Salário Líquido:";
            // 
            // LVCasdastroFuncionario
            // 
            this.LVCasdastroFuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHNome,
            this.CHCPF,
            this.CHSalarioBruto,
            this.CHDescontoSalario,
            this.CHAdicionalSalario,
            this.CHSalarioLiquido});
            this.LVCasdastroFuncionario.FullRowSelect = true;
            this.LVCasdastroFuncionario.GridLines = true;
            this.LVCasdastroFuncionario.HideSelection = false;
            this.LVCasdastroFuncionario.Location = new System.Drawing.Point(17, 225);
            this.LVCasdastroFuncionario.Name = "LVCasdastroFuncionario";
            this.LVCasdastroFuncionario.Size = new System.Drawing.Size(498, 118);
            this.LVCasdastroFuncionario.TabIndex = 0;
            this.LVCasdastroFuncionario.UseCompatibleStateImageBehavior = false;
            this.LVCasdastroFuncionario.View = System.Windows.Forms.View.Details;
            // 
            // CHNome
            // 
            this.CHNome.Text = "Nome";
            this.CHNome.Width = 109;
            // 
            // CHCPF
            // 
            this.CHCPF.Text = "CPF";
            this.CHCPF.Width = 100;
            // 
            // CHSalarioBruto
            // 
            this.CHSalarioBruto.Text = "Salário Bruto";
            this.CHSalarioBruto.Width = 78;
            // 
            // CHDescontoSalario
            // 
            this.CHDescontoSalario.Text = "Desconto";
            // 
            // CHAdicionalSalario
            // 
            this.CHAdicionalSalario.Text = "Adicional";
            // 
            // CHSalarioLiquido
            // 
            this.CHSalarioLiquido.Text = "Salário Líquido";
            this.CHSalarioLiquido.Width = 87;
            // 
            // TBNome
            // 
            this.TBNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "nome", true));
            this.TBNome.Location = new System.Drawing.Point(76, 25);
            this.TBNome.Name = "TBNome";
            this.TBNome.Size = new System.Drawing.Size(450, 20);
            this.TBNome.TabIndex = 3;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.appFormsDataSet;
            // 
            // appFormsDataSet
            // 
            this.appFormsDataSet.DataSetName = "AppFormsDataSet";
            this.appFormsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBCargo
            // 
            this.CBCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cargo", true));
            this.CBCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCargo.FormattingEnabled = true;
            this.CBCargo.Items.AddRange(new object[] {
            "Funcionário",
            "Gerente"});
            this.CBCargo.Location = new System.Drawing.Point(405, 51);
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.Size = new System.Drawing.Size(121, 21);
            this.CBCargo.TabIndex = 4;
            // 
            // TBCPF
            // 
            this.TBCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cpf", true));
            this.TBCPF.Location = new System.Drawing.Point(76, 54);
            this.TBCPF.Name = "TBCPF";
            this.TBCPF.Size = new System.Drawing.Size(100, 20);
            this.TBCPF.TabIndex = 6;
            // 
            // TBDescontoSalario
            // 
            this.TBDescontoSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "desconto_salario", true));
            this.TBDescontoSalario.Location = new System.Drawing.Point(76, 106);
            this.TBDescontoSalario.Name = "TBDescontoSalario";
            this.TBDescontoSalario.Size = new System.Drawing.Size(100, 20);
            this.TBDescontoSalario.TabIndex = 8;
            this.TBDescontoSalario.TextChanged += new System.EventHandler(this.TBDescontoSalario_TextChanged);
            this.TBDescontoSalario.Leave += new System.EventHandler(this.TBDescontoSalario_Leave);
            // 
            // TBSalarioBruto
            // 
            this.TBSalarioBruto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "salario_bruto", true));
            this.TBSalarioBruto.Location = new System.Drawing.Point(76, 80);
            this.TBSalarioBruto.Name = "TBSalarioBruto";
            this.TBSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.TBSalarioBruto.TabIndex = 10;
            this.TBSalarioBruto.TextChanged += new System.EventHandler(this.TBSalarioBruto_TextChanged);
            this.TBSalarioBruto.Leave += new System.EventHandler(this.TBSalarioBruto_Leave);
            // 
            // TBAdicionalSalario
            // 
            this.TBAdicionalSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "adicional_salario", true));
            this.TBAdicionalSalario.Location = new System.Drawing.Point(76, 132);
            this.TBAdicionalSalario.Name = "TBAdicionalSalario";
            this.TBAdicionalSalario.Size = new System.Drawing.Size(100, 20);
            this.TBAdicionalSalario.TabIndex = 12;
            this.TBAdicionalSalario.TextChanged += new System.EventHandler(this.TBAdicionalSalario_TextChanged);
            this.TBAdicionalSalario.Leave += new System.EventHandler(this.TBAdicionalSalario_Leave);
            // 
            // TBSalarioLiquido
            // 
            this.TBSalarioLiquido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "salario_liquido", true));
            this.TBSalarioLiquido.Location = new System.Drawing.Point(426, 132);
            this.TBSalarioLiquido.Name = "TBSalarioLiquido";
            this.TBSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.TBSalarioLiquido.TabIndex = 14;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(135, 181);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(264, 23);
            this.BtnSalvar.TabIndex = 15;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnOrdenarLista
            // 
            this.BtnOrdenarLista.Location = new System.Drawing.Point(286, 349);
            this.BtnOrdenarLista.Name = "BtnOrdenarLista";
            this.BtnOrdenarLista.Size = new System.Drawing.Size(134, 23);
            this.BtnOrdenarLista.TabIndex = 16;
            this.BtnOrdenarLista.Text = "Ordenar Lista (por Nome)";
            this.BtnOrdenarLista.UseVisualStyleBackColor = true;
            this.BtnOrdenarLista.Click += new System.EventHandler(this.BtnOrdenarLista_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(426, 349);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 17;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // CheckSemDesconto
            // 
            this.CheckSemDesconto.AutoSize = true;
            this.CheckSemDesconto.Location = new System.Drawing.Point(183, 109);
            this.CheckSemDesconto.Name = "CheckSemDesconto";
            this.CheckSemDesconto.Size = new System.Drawing.Size(96, 17);
            this.CheckSemDesconto.TabIndex = 18;
            this.CheckSemDesconto.Text = "Sem Desconto";
            this.CheckSemDesconto.UseVisualStyleBackColor = true;
            this.CheckSemDesconto.CheckedChanged += new System.EventHandler(this.CheckSemDesconto_CheckedChanged);
            this.CheckSemDesconto.CheckStateChanged += new System.EventHandler(this.CheckSemDesconto_CheckStateChanged);
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
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 384);
            this.Controls.Add(this.CheckSemDesconto);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnOrdenarLista);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(LSalarioLiquido);
            this.Controls.Add(this.TBSalarioLiquido);
            this.Controls.Add(LAdicionalSalario);
            this.Controls.Add(this.TBAdicionalSalario);
            this.Controls.Add(LSalarioBruto);
            this.Controls.Add(this.TBSalarioBruto);
            this.Controls.Add(LDescontoSalario);
            this.Controls.Add(this.TBDescontoSalario);
            this.Controls.Add(LCPF);
            this.Controls.Add(this.TBCPF);
            this.Controls.Add(LCargo);
            this.Controls.Add(this.CBCargo);
            this.Controls.Add(LNome);
            this.Controls.Add(this.TBNome);
            this.Controls.Add(this.LVCasdastroFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appFormsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVCasdastroFuncionario;
        private AppFormsDataSet appFormsDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private AppFormsDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private AppFormsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ColumnHeader CHNome;
        private System.Windows.Forms.ColumnHeader CHCPF;
        private System.Windows.Forms.ColumnHeader CHSalarioBruto;
        private System.Windows.Forms.ColumnHeader CHDescontoSalario;
        private System.Windows.Forms.ColumnHeader CHAdicionalSalario;
        private System.Windows.Forms.ColumnHeader CHSalarioLiquido;
        private System.Windows.Forms.TextBox TBNome;
        private System.Windows.Forms.ComboBox CBCargo;
        private System.Windows.Forms.TextBox TBCPF;
        private System.Windows.Forms.TextBox TBDescontoSalario;
        private System.Windows.Forms.TextBox TBSalarioBruto;
        private System.Windows.Forms.TextBox TBAdicionalSalario;
        private System.Windows.Forms.TextBox TBSalarioLiquido;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnOrdenarLista;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.CheckBox CheckSemDesconto;
    }
}