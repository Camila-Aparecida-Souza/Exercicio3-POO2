using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Funcionario
    {
        int matricula;
        String nome;
        String cpf;
        String cargo;

        public Funcionario(int matricula, String nome, String cpf, String cargo)   //Para o funcionário ser criado é necessário ter CPF válido
        {
            if (this.ValidarCpf(cpf))
            {
                this.RegistrarFuncionario(matricula, nome, cpf, cargo);
            }
        }

        public virtual void RegistrarFuncionario(int matricula, String nome, String cpf, String cargo)   
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cpf = cpf;
            this.cargo = cargo;
        }

        public Boolean ValidarCpf (String cpf) 
        {
            return true;
        }

        public override string ToString()
        {
            return "\n\nMatrícula: " + matricula + "\nNome: " + nome + "\nCPF: " + cpf + "\nCargo: " + cargo + "\n";
        }
    }
}
