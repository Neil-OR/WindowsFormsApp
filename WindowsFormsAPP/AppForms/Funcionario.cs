using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForms
{
    class Funcionario
    {
        private string nome;
        private string cPF;
        private string cargo;
        private float salarioBruto;
        private float descontoSalario;
        private float adicionalSalario;
        private float salarioLiquido;


        public string Nome { get => nome; set => nome = value; }
        public string CPF { get => cPF; set => cPF = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public float SalarioBruto { get => salarioBruto; set => salarioBruto = value; }
        public float DescontoSalario { get => descontoSalario; set => descontoSalario = value; }
        public float AdicionalSalario { get => adicionalSalario; set => adicionalSalario = value; }
        public float SalarioLiquido { get => salarioLiquido; set => salarioLiquido = value; }

        public Funcionario()
        {

        }

        public Funcionario(string nome,
                           string cpf, 
                           float salarioBruto)
        {
            this.nome = nome;
            this.cPF = cpf;
            this.salarioBruto = salarioBruto;
        }

        public Funcionario(string nome, 
                           string cpf, 
                           string cargo, 
                           float salarioBruto, 
                           float descontoSalario, 
                           float adicionalSalario)
        {
            this.nome = nome;
            this.cPF = cpf;
            this.cargo = cargo;
            this.salarioBruto = salarioBruto;
            this.descontoSalario = descontoSalario;
            this.adicionalSalario = adicionalSalario;
        }

        public void CalcularLiquido(float salarioBruto,
                                    float adicionalSalario) => this.salarioLiquido = (salarioBruto + adicionalSalario);

        public void CalcularLiquido(float salarioBruto,
                                    float descontoSalario,
                                    float adiconalSalario) => this.salarioLiquido = ((salarioBruto - descontoSalario) + adiconalSalario);

        public void CalcularBonus() => this.adicionalSalario = ((this.salarioBruto * 1) / 100);
    }
}
