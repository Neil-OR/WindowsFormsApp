using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForms
{
    public partial class CadastroFuncionario : Form
    {
        ListaFuncionario listaFuncionario = new ListaFuncionario();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appFormsDataSet);

        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.Fill(this.appFormsDataSet.Funcionario);
            
            LimparCampos();

            AppFormsDataSet.FuncionarioDataTable funcionarioRows = funcionarioTableAdapter.GetData();

            for (int contador = 0; contador > funcionarioRows.Count; contador++)
            {
                ListViewItem item = new ListViewItem(new[] { Convert.ToString(funcionarioRows.Rows[contador].ItemArray[1]),
                                                             Convert.ToString(funcionarioRows.Rows[contador].ItemArray[3]),
                                                             Convert.ToString(funcionarioRows.Rows[contador].ItemArray[4]),
                                                             Convert.ToString(funcionarioRows.Rows[contador].ItemArray[5]),
                                                             Convert.ToString(funcionarioRows.Rows[contador].ItemArray[6]),
                                                             Convert.ToString(funcionarioRows.Rows[contador].ItemArray[7])});

                LVCasdastroFuncionario.Items.Add(item);

            }
        }

        private void TBSalarioBruto_TextChanged(object sender, EventArgs e)
        {
        }

        private void TBSalarioBruto_Leave(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void TBDescontoSalario_TextChanged(object sender, EventArgs e)
        {
        }

        private void TBDescontoSalario_Leave(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void CheckSemDesconto_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CheckSemDesconto_CheckStateChanged(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void TBAdicionalSalario_TextChanged(object sender, EventArgs e)
        {
        }

        private void TBAdicionalSalario_Leave(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos)
            {
                listaFuncionario.ArmazenarFuncionario(TBNome.Text,
                                                      TBCPF.Text,
                                                      CBCargo.Text,
                                                      float.Parse(TBSalarioBruto.Text),
                                                      float.Parse(TBDescontoSalario.Text),
                                                      CheckSemDesconto.Checked,
                                                      float.Parse(TBAdicionalSalario.Text));

                int index = listaFuncionario.BurcarFuncinario(TBCPF.Text);
                var funcionarioObj = listaFuncionario.RetornarObjetoFuncionario(index);

                ListViewItem item = new ListViewItem(new[] { funcionarioObj.Nome,
                                                             funcionarioObj.CPF,
                                                             funcionarioObj.SalarioBruto.ToString("N2"),
                                                             funcionarioObj.DescontoSalario.ToString("N2"),
                                                             funcionarioObj.AdicionalSalario.ToString("N2"),
                                                             funcionarioObj.SalarioLiquido.ToString("N2") });

                LVCasdastroFuncionario.Items.Add(item);

                MessageBox.Show($"Calculou Salário Líquido para o funcionário {TBNome.Text}", "Atenção");
                LimparCampos();

                try
                {
                    funcionarioTableAdapter.Insert(funcionarioObj.Nome,
                                                   funcionarioObj.Cargo,
                                                   funcionarioObj.CPF,
                                                   Convert.ToDecimal(funcionarioObj.SalarioBruto),
                                                   Convert.ToDecimal(funcionarioObj.AdicionalSalario),
                                                   Convert.ToDecimal(funcionarioObj.DescontoSalario),
                                                   Convert.ToDecimal(funcionarioObj.SalarioLiquido),
                                                   "Não informado", "Não informado", "Não informado");
                }
                catch (Exception)
                {
                    MessageBox.Show($"Erro ao salvar registro na tabela Funcionario.");
                }
            }


        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            for (int itemList = LVCasdastroFuncionario.SelectedItems.Count - 1; itemList >= 0; itemList--)
            {
                ListViewItem lista = LVCasdastroFuncionario.SelectedItems[itemList];
                LVCasdastroFuncionario.Items.Remove(lista);

                string nome = lista.SubItems[0].Text;
                listaFuncionario.RemoverFuncionario(nome);
            }
        }

        private void BtnOrdenarLista_Click(object sender, EventArgs e)
        {
            listaFuncionario.OrdenarFuncionario();
            LVCasdastroFuncionario.Items.Clear();

            int TamanhoLista = listaFuncionario.RetornarTamanhoLista();

            Funcionario funcionarioObj = new Funcionario();

            for (int contador = 0; contador < TamanhoLista; contador++)
            {
                funcionarioObj = listaFuncionario.RetornarObjetoFuncionario(contador);

                ListViewItem item = new ListViewItem(new[] { funcionarioObj.Nome,
                                                             funcionarioObj.CPF,
                                                             funcionarioObj.SalarioBruto.ToString("N2"),
                                                             funcionarioObj.DescontoSalario.ToString("N2"),
                                                             funcionarioObj.AdicionalSalario.ToString("N2"),
                                                             funcionarioObj.SalarioLiquido.ToString("N2") });

                LVCasdastroFuncionario.Items.Add(item);
            }
        }

        private void LimparCampos()
        {
            TBNome.Text = "";
            TBCPF.Text = "";
            TBSalarioBruto.Text = "0";
            TBDescontoSalario.Text = "0";
            TBAdicionalSalario.Text = "0";
            TBSalarioLiquido.Text = "0";
        }

        private void FormatarCampos()
        {
            float valor;

            valor = float.Parse(TBSalarioBruto.Text);
            TBSalarioBruto.Text = valor.ToString("N2");

            valor = float.Parse(TBDescontoSalario.Text);
            TBDescontoSalario.Text = valor.ToString("N2");

            valor = float.Parse(TBAdicionalSalario.Text);
            TBAdicionalSalario.Text = valor.ToString("N2");

            valor = float.Parse(TBSalarioLiquido.Text);
            TBSalarioLiquido.Text = valor.ToString("N2");
        }

        public void CalcularLiquido()
        {
            if (CheckSemDesconto.Checked)
                TBSalarioLiquido.Text = Convert.ToString(float.Parse(TBSalarioBruto.Text) + float.Parse(TBAdicionalSalario.Text));
            else
                TBSalarioLiquido.Text = Convert.ToString(float.Parse(TBSalarioBruto.Text) - float.Parse(TBDescontoSalario.Text) + float.Parse(TBAdicionalSalario.Text));
        }

        private bool ValidarCampos
        {
            get
            {
                if (TBNome.Text == "")
                {
                    MessageBox.Show("Nome Invalido", "Atenção");
                    return false;
                }
                if (TBSalarioBruto.Text == "" || TBSalarioBruto.Text == "0")
                {
                    MessageBox.Show("Salário Invalido", "Atenção");
                    return false;
                }

                return true;
            }
        }

    }
}
