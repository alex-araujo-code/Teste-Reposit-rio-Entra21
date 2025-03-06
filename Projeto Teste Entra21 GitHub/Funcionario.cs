using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste_Entra21_GitHub
{
    public class Funcionario
    {
        public string Nome;
        public int Idade;
        public string Cargo;
        public double Salario;

        public void Apresentacao()
        {
            Console.WriteLine($"""

                Funcionario:
                
                Nome: {this.Nome}
                Idade: {this.Idade}
                Cargo: {this.Cargo}
                Salário: {this.Salario}
                Salário Líquido: {SalarioLiquido()}
                """);
        }

        public double SalarioLiquido()
        {
            if (Cargo == "Estagiário")
                return Salario;
            return Salario * 0.73;
        }
    }
}
