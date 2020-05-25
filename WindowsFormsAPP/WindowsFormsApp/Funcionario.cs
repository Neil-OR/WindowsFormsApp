﻿using System;
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

        //TrÊs Sobrecargas do Construtor "Funcionario"

        // Construtor com 3 parametros
        public Funcionario(string nomeParam, float salarioBrutoParam, string CPF)
        {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.cpf = CPF;
        }

        // Construtor vazio
        public Funcionario()
        {

        }

        // Construtor com cinco parametros
        public Funcionario(string nomeParam, float salarioBrutoParam, 
                          float descontoParam, float adicionalParam, string CPF)
        {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.adicional = adicionalParam;
            this.desconto = descontoParam;
            this.cpf = CPF;
        }

        
        // Sobrecarga do Metodo CalcularLiquido 
        // Sobrecarga= diferencia-se pela assinatura (parametros)
        // Executa ou um ou outro metodo. Vai depender dos parametros.
        public void CalcularLiquido(float salario, float desconto, float adicional) 
        {
            this.salarioLiquido = ((salario - desconto) + adicional);
        }

        public void CalcularLiquido(float salario, float adicional)
        {
            this.salarioLiquido = (salario + adicional);
        }

        virtual public void CalcularBonus()
        {
            this.salarioLiquido = ((this.salarioLiquido * 1) /100);
        }
    }
}
