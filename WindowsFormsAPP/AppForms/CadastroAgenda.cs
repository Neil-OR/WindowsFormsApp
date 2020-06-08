using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForms.EntitiesAgenda;

namespace AppForms
{
    public partial class CadastroAgenda : Form
    {
        public Agenda agenda = new Agenda();

        public CadastroAgenda()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appFormsDataSet);

        }

        private void CadastroAgenda_Load(object sender, EventArgs e)
        { 
            this.funcionarioTableAdapter.Fill(this.appFormsDataSet.Funcionario);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TBNome.Text = string.Empty;
            TBEndereco.Text = string.Empty;
            TBTelefone.Text = string.Empty;
            TBEmail.Text = string.Empty;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (LVCasdastroAgenda.SelectedItems.Count > 0)
            {
                var pessoa = new Pessoa(TBNome.Text,
                                        TBEndereco.Text,
                                        TBTelefone.Text,
                                        TBEmail.Text);

                ListViewItem item = LVCasdastroAgenda.SelectedItems[0];
                int index = LVCasdastroAgenda.Items.IndexOf(LVCasdastroAgenda.SelectedItems[0]);
                agenda.Editar(pessoa, index);

                LVCasdastroAgenda.SelectedItems[0].SubItems[0].Text = pessoa.Nome;
                LVCasdastroAgenda.SelectedItems[0].SubItems[1].Text = pessoa.Endereco;
                LVCasdastroAgenda.SelectedItems[0].SubItems[2].Text = pessoa.Telefone;
                LVCasdastroAgenda.SelectedItems[0].SubItems[3].Text = pessoa.Email;

                var pessoaObj = agenda.RetornarPessoa(index);

                try
                {
                    funcionarioTableAdapter.Insert(pessoaObj.Nome,
                                                   "Não Especificado",
                                                   "Não Especificado",
                                                   0,
                                                   0,
                                                   0,
                                                   0,
                                                   pessoaObj.Endereco,
                                                   pessoaObj.Telefone,
                                                   pessoaObj.Email);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Erro ao salvar registro na tabela Funcionario.");
                }

            }
            else
            {
                agenda.Armazenar(TBNome.Text,
                                 TBEndereco.Text,
                                 TBTelefone.Text,
                                 TBEmail.Text);

                int index = agenda.BuscarPessoa(TBNome.Text);
                var pessoaObj = agenda.RetornarPessoa(index);

                ListViewItem item = new ListViewItem(new[] { TBNome.Text,
                                                             TBEndereco.Text,
                                                             TBTelefone.Text,
                                                             TBEmail.Text });
                LVCasdastroAgenda.Items.Add(item);

                try
                {
                    funcionarioTableAdapter.Insert(pessoaObj.Nome,
                                                   "Não Especificado",
                                                   "Não Especificado",
                                                   0,
                                                   0,
                                                   0,
                                                   0,
                                                   pessoaObj.Endereco, 
                                                   pessoaObj.Telefone, 
                                                   pessoaObj.Email);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Erro ao salvar registro na tabela Funcionario.");
                }
            }
        }
    }
}
