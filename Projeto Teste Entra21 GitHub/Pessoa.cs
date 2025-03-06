using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste_Entra21_GitHub
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void DizerOi()
        {
            Console.WriteLine($"\nA pessoa {this.Nome} disse 'Oi'");
        }
    }
}
