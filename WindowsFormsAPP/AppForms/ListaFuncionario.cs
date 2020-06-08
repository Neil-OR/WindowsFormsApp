using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AppForms
{
    class ListaFuncionario
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        public void ArmazenarFuncionario(string nome,
                                         string cpf,
                                         string cargo,
                                         float salarioBruto,
                                         float descontoSalario,
                                         bool semDesconto,
                                         float adicionalSalario)
        {
            if (cargo != "Gerente")
            {
                Funcionario funcionarioObj = new Funcionario(nome, 
                                                             cpf, 
                                                             cargo, 
                                                             salarioBruto, 
                                                             descontoSalario, 
                                                             adicionalSalario);

                funcionarioObj.CalcularBonus();

                if (semDesconto)
                    funcionarioObj.CalcularLiquido(salarioBruto,
                                                   adicionalSalario);
                else
                    funcionarioObj.CalcularLiquido(salarioBruto, 
                                                   descontoSalario, 
                                                   adicionalSalario);

                funcionarios.Add(funcionarioObj);
            }
            else
            {
                Gerente gerenteObj = new Gerente(nome, 
                                                 cpf, 
                                                 cargo, 
                                                 salarioBruto, 
                                                 descontoSalario, 
                                                 adicionalSalario);

                gerenteObj.CalcularBonus();

                if (semDesconto)
                    gerenteObj.CalcularLiquido(salarioBruto, adicionalSalario);
                else
                    gerenteObj.CalcularLiquido(salarioBruto, descontoSalario, adicionalSalario);

                funcionarios.Add(gerenteObj);
            }

        }

        public void RemoverFuncionario(string cpf) => funcionarios.RemoveAll(f => f.CPF == cpf);

        public int BurcarFuncinario(string cpf) => funcionarios.FindIndex(f => f.CPF == cpf);

        public void OrdenarFuncionario() => funcionarios = funcionarios.OrderBy(f => f.Nome).ToList();

        public int RetornarTamanhoLista() => funcionarios.Count();

        public Funcionario RetornarObjetoFuncionario(int index)
        {
            var funcionarioObj = funcionarios[index];
            return funcionarioObj;
        }
    }
}
