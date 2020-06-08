using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForms
{
    class Gerente : Funcionario
    {
        public Gerente(string nome,
                       string cpf, 
                       string cargo, 
                       float salarioBruto, 
                       float descontoSalario, 
                       float adicionalSalario)
        {
            Nome = nome;
            CPF = cpf;
            Cargo = cargo;
            SalarioBruto = salarioBruto;
            DescontoSalario = descontoSalario;
            AdicionalSalario = adicionalSalario;
        }

        public new void CalcularBonus() => this.AdicionalSalario = ((this.SalarioBruto * 2) / 100);

    }
}
