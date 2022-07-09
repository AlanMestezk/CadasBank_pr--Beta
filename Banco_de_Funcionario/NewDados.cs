

namespace Banco_de_Funcionario {
    internal class NewData {

        public int UserId;
        public string Nome;
        public string Sobrenome;
        public string Cargo;
        public double Salario;
        public char Sexo;


        public NewData() {

        }

        public NewData(int userId, string nome, string sobrenome) {
            UserId = userId;
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public NewData(int userId, string nome, string sobrenome, string cargo, double salario, char sexo) : this(userId, nome, sobrenome) {
            Cargo = cargo;
            Salario = salario;
            Sexo = sexo;
        }

        public string Text() {
            Console.WriteLine("       ==============================================================================================");
            Console.WriteLine("       ==============================================================================================");
            Console.WriteLine("                                        >>>> FUNCIONÁRIO CADASTRADO <<<<");
            Console.WriteLine("       ==============================================================================================");
            Console.WriteLine("       ==============================================================================================");

            return " ";
        }

        

        override public string ToString() {
            Console.WriteLine(Text());
            Console.WriteLine();
            return $" Id do Usuário: {UserId} || Nome do funcionário: {Nome} {Sobrenome} || Sexo: {Sexo} || Cargo: {Cargo} || Salário: {Salario} reais ";
        }
    }
}
