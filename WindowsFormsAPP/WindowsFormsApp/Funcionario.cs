using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Funcionario
    {

        public string nome, cpf, cargo;
        public float salarioBruto, desconto, adicional, salarioLiquido;

        
        public Funcionario(string nomeParam, float salarioBrutoParam, string CPF)
        {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.cpf = CPF;
        }

      
        public Funcionario()
        {

        }

        
        public Funcionario(string nomeParam, float salarioBrutoParam, 
                          float descontoParam, float adicionalParam, string CPF, string cargoParam)
        {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.adicional = adicionalParam;
            this.desconto = descontoParam;
            this.cpf = CPF;
            this.cargo = cargoParam;
        }

        
        public void CalcularLiquido(float salario, float desconto, float adicional) 
        {
            this.salarioLiquido = ((salario - desconto) + adicional);
            CalcularBonus();
        }

        public void CalcularLiquido(float salario, float adicional)
        {
            this.salarioLiquido = (salario + adicional);
            CalcularBonus();
        }

        public void CalcularBonus()
        {
            this.salarioLiquido = ((this.salarioLiquido * 1) /100);
        }
    }
}
