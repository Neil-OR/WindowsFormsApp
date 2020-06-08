using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void TSMICadastroFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.ShowDialog();
        }

        private void TSMIAgenda_Click(object sender, EventArgs e)
        {
            CadastroAgenda cadastroAgenda = new CadastroAgenda();
            cadastroAgenda.ShowDialog();
        }


        private void TSMISair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
