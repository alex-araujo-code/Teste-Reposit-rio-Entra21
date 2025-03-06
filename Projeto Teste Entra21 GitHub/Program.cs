using System.Security.Cryptography.X509Certificates;

namespace Projeto_Teste_Entra21_GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Alex";
            pessoa.Idade = 20;
            Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}");

            pessoa.DizerOi();

            Funcionario alex = new Funcionario();
            alex.Nome = "Alex";
            alex.Idade = 20;
            alex.Cargo = "Estagiário";
            alex.Salario = 7390.99;

            Funcionario chefe = new Funcionario();
            chefe.Nome = "Gab";
            chefe.Idade = 32;
            chefe.Cargo = "Chefe de Setor";
            chefe.Salario = 25666.01;

            alex.Apresentacao();
            chefe.Apresentacao();
        }
    }
}