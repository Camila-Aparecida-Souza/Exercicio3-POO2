using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula;
            String nome;
            String cpf;
            String cargo;

            Console.Write(":::Preencha com os dados do Funcionário:::\n");

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Cargo: ");
            cargo = Console.ReadLine();

            Funcionario funcionario = new Funcionario(matricula, nome, cpf, cargo);  //as informações do "objeto" que foram preenchidas

            Console.WriteLine("\n:::Dados dos Funcionários:::");
            Console.Write(funcionario.ToString());

            Funcionario winglerson = new Funcionario(10030, "Winglerson", "100.200.300-45", "Marceneiro Pleno");  //as informações do "objeto" Winglerson já estão preenchidas
            Console.WriteLine(winglerson.ToString());

            Console.ReadLine();
        }
    }
}
