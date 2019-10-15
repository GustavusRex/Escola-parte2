using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Aluno : Pessoa // Classe onde guarda as caracteriscas de Aluno e herdado de pessoa
    {
        public int Matricula;
        public bool Bolsista;
        public string Situacao;

        public void ColoqueAsInformacaosAlunos() // metodo onde irá ser chamado para armazenar dados nas variaveis
        {
            Random random = new Random();  // Classe Random para criar sentenças de números aleatórios finitos
            Matricula = random.Next(10000000);

            Console.WriteLine("\nDigite o nome do(a) Aluno(a)");
            Nome = Console.ReadLine();
            // "SoLetras" é o metedo chamado para validar dos dados dentro da string
            while (!SoLetras(Nome)) // Validação do nome aonde só passa sem entrar no loop se for caracteres do tipo letra, maior que 3 caracteres e não nulo
            {
                Console.WriteLine("\nPor favor digite o nome sem caracteres, numeros ou pontuções (Lembrando que não pode ser nulo) e maior que 3 caracteres\n");
                Nome = Console.ReadLine();

            }

            Console.WriteLine($"\nDigite o sexo do(a) Aluno(a) {Nome}");
            Sexo = Console.ReadLine().ToUpper(); // Toda letra escrita aqui será armazenada como maiuscula

            while (Sexo != "M" && Sexo != "F") // Validação do sexo só entra no loop em caso for nula, tiver caracteres sem ser letras e fora da condição de M E F
            {
                Console.WriteLine("Sexo invalido, por favor digite novamente com: M ou F\n");
                Sexo = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($"\nDigite a idade do(a) Aluno(a) {Nome} ");
            // TryParse metodo: para tentar convertar o que foi digitado em string em um tipo byte (números de 0 - 255)
            byte.TryParse(Console.ReadLine(), out Idade);
            while (Idade <= 2) // Caso não conseguir converter a string para apenas números to tipo byte entra no loop ou número ser menor ou igual a 2 (3 é Idade mínima da escola)
            {
                Console.WriteLine("Um aluno deve ter no mínimo 3 anos");
                Console.WriteLine("\nIdade invalida por favor digitar novamente com um número inteiro\n");
                byte.TryParse(Console.ReadLine(), out Idade);

            }
            Console.WriteLine("\nO Aluno é bolsista?");
            string OpcaoBolsa = Console.ReadLine().ToUpper();
            
            while (OpcaoBolsa != "S" && OpcaoBolsa != "N") //Toda letra escrita aqui será armazenada como maiuscula
            {

                Console.WriteLine("Opção invalida porfavor digitar (S) para sim e (N) para não"); // Bolsista entra no loop enquanto as condições de S e N não forem atendidas
                OpcaoBolsa = Console.ReadLine().ToUpper();
            }
            if (OpcaoBolsa == "S")
                Bolsista = true;
            else
                Bolsista = false;
            if (Bolsista == true)
                Situacao = "Sim";
            else
                Situacao = "Não";

        }


    }
}