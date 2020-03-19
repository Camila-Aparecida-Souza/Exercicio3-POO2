using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class FuncionarioEnsinoSuperior : Funcionario
    {
        String superior;

        public override void RegistrarFuncionario(int matricula, String nome, String cpf, String cargo)  //override sobrescreve o comportamento, indica que o metodo pode ser sobrescrito
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cpf = cpf;
            this.cargo = cargo;
            this.superior = superior;
        }

    }
}
