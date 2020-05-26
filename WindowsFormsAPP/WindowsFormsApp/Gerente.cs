using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Gerente: Funcionario 
    {
         public new void CalcularBonus()
        {
            this.salarioLiquido = ((this.salarioLiquido * 2) / 100);
        }
    }
}
