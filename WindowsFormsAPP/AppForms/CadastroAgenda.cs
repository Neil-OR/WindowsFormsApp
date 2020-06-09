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

            List<Pessoa> pessoaRegistro = ManipulaAgenda.Manipulação.SelecionarRegistro();

            for (int indice = 0; indice < pessoaRegistro.Count; indice++) {
                ListViewItem item = new ListViewItem(new[] { pessoaRegistro[indice].Nome,
                                                             pessoaRegistro[indice].Endereco,
                                                             pessoaRegistro[indice].Telefone,
                                                             pessoaRegistro[indice].Email});
                LVCasdastroAgenda.Items.Add(item);

                agenda.Armazenar(pessoaRegistro[indice].Nome,
                                 pessoaRegistro[indice].Endereco,
                                 pessoaRegistro[indice].Telefone,
                                 pessoaRegistro[indice].Email)
            }

            


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

                ManipulaAgenda.Manipulação.AtualizarRegistro(TBNome.Text,
                                        TBEndereco.Text,
                                        TBTelefone.Text,
                                        TBEmail.Text);
            }
            else
            {
                agenda.Armazenar(TBNome.Text,
                                 TBEndereco.Text,
                                 TBTelefone.Text,
                                 TBEmail.Text);

                ListViewItem item = new ListViewItem(new[] { TBNome.Text,
                                                             TBEndereco.Text,
                                                             TBTelefone.Text,
                                                             TBEmail.Text });
                LVCasdastroAgenda.Items.Add(item);

                ManipulaAgenda.Manipulação.InserirRegitro(TBNome.Text,
                                                          TBEndereco.Text,
                                                          TBTelefone.Text,
                                                          TBEmail.Text);
;            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (LVCasdastroAgenda.SelectedItems.Count > 0)
            {
                ListViewItem item = LVCasdastroAgenda.SelectedItems[0];
                TBNome.Text = item.SubItems[0].Text;
                TBEndereco.Text = item.SubItems[1].Text;
                TBTelefone.Text = item.SubItems[2].Text;
                TBEmail.Text = item.SubItems[3].Text;
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ListViewItem item = LVCasdastroAgenda.SelectedItems[0];
            int index = LVCasdastroAgenda.Items.IndexOf(item);

            string nomeRegistro = LVCasdastroAgenda.SelectedItems[0].SubItems[0].Text;

            LVCasdastroAgenda.SelectedItems[0].SubItems.Clear();
            agenda.Remover(index);

            LVCasdastroAgenda.SelectedItems[0].Selected = false;

            ManipulaAgenda.Manipulação.DeletarRegistro(nomeRegistro);
        }

        private void LVCasdastroAgenda_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int coluna = e.Column;

            if (coluna == 0)
            {
                agenda.Ordenar();
                LVCasdastroAgenda.Items.Clear();
                int tamanhoList = agenda.RetornarTamanhoLista();

                for (int indice = 0; indice < tamanhoList; indice++)
                {
                    var pessoa = agenda.RetornarPessoa(indice);
                    ListViewItem item = new ListViewItem(new[] { pessoa.Nome,
                                                                 pessoa.Endereco,
                                                                 pessoa.Telefone,
                                                                 pessoa.Email });
                    LVCasdastroAgenda.Items.Add(item);
                }
            }
        }
    }
}
