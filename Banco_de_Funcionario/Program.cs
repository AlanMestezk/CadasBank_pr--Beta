
using System;

namespace Banco_de_Funcionario {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("========================");
            Console.WriteLine("   § CASDASBANK §");
            Console.WriteLine();
            Console.WriteLine("    CADASTRE AQUI");
            Console.WriteLine(" SEU NOVO FUNCIONÁRIO");
            Console.WriteLine("========================");
            Console.WriteLine();

            Console.WriteLine("^^^^^^^^^^^^");
            Console.WriteLine("FAÇA O LOGIN");
            Console.WriteLine("vvvvvvvvvvvv");
            Console.WriteLine();

            Console.Write("DIGITE O USUÁRIO: ");
            string usuario = Console.ReadLine();
            Console.Write("DIGITE A SENHA: ");
            int senha = int.Parse(Console.ReadLine());

            string resposta;

            if(usuario == "Alan" &&  senha == 1234 ) {

                Console.WriteLine();
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("         BEM VINDO MEU QUERIDO");
                Console.WriteLine("  VAMOS LÁ, DIGITE AS INFORMAÇÕES ABAIXO");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                Console.WriteLine();
                Console.Write("Digite o Id que será usado pelo novo funcionário (numérico): ");
                int userId = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o sobrenome do funcionário: ");
                string sobrenome = Console.ReadLine();
                Console.Write("Digite o cargo que o funcionário irá exercer: ");
                string cargo = Console.ReadLine();
                Console.Write("Digite o salário que o funcionário irá receber: ");
                double salario = double.Parse(Console.ReadLine());
                Console.Write("Sexo do funcionário (Digite 'F' para feminino e 'M' para masculino): ");
                char sexo = char.Parse(Console.ReadLine());

                NewData dados = new NewData(userId, nome, sobrenome, cargo, salario, sexo);

                Console.WriteLine();
                Console.WriteLine(dados);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("       §§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
                Console.WriteLine("       §§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
                Console.WriteLine("                                              PARA UM NOVO CADASTRO");
                Console.WriteLine("                                           OU PARA ENCERRAR O CADASBANK");
                Console.WriteLine("                                              CLIQUE NA TECLA ENTER");
                Console.WriteLine("       §§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
                Console.WriteLine("       §§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
                Console.WriteLine();

            }
            else {
                Console.WriteLine();
                Console.WriteLine("  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                Console.WriteLine("   SENHA OU USUÁRIO INCORRETO,");
                Console.WriteLine("     CLIQUE NA TECLA ENTER");
                Console.WriteLine("       E TENTE NOVAMENTE!");
                Console.WriteLine("   >>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }

        }
    }
}