using System;
using System.Collections.Generic;
namespace Escola
{
    class Professor : Pessoa // Classe onde guarda as caracteriscas de professor e herdado de pessoa
    {
        public List<Professor> ListaProfessor = new List<Professor>();
        public int Registro;
        uint NumeroProfessores;



        public void ColoqueAsInformacaosProfessor() // metodo onde irá ser chamado para armazenar dados nas variaveis
        {
            Random random = new Random(); // Classe Random para criar sentenças de números aleatórios finitos
            Registro = random.Next(10000000);
        
            Nome = Console.ReadLine();
            // "SoLetras" é o metedo chamado para validar dos dados dentro da string
            while (!SoLetras(Nome)) // Validação do nome aonde só passa sem entrar no loop se for caracteres do tipo letra, maior que 3 caracteres e não nulo
            {
                Console.WriteLine("\nPor favor digite o nome sem caracteres, numeros ou pontuções (Lembrando que não pode ser nulo) e maior que 3 caracteres\n");
                Nome = Console.ReadLine();

            }

            Console.WriteLine($"\nDigite o sexo do(a) Professor(a) {Nome}");
            Sexo = Console.ReadLine().ToUpper(); // Toda letra escrita aqui será armazenada como maiuscula

            while ((Sexo != "M" && Sexo != "F")) // Sexo entra no loop enquanto as condições de F e M não forem atendidas
            {
                Console.WriteLine("Sexo invalido, por favor digite novamente com: M ou F\n");
                Sexo = Console.ReadLine().ToUpper();
            }


            Console.WriteLine($"\nDigite a idade do(a) Professor(a) {Nome}");
            byte.TryParse(Console.ReadLine(), out Idade);
            // TryParse para tentar convertar o que foi amarzenado na string em um tipo byte 
            while ((Idade <= 21 || Idade >= 80)) // Caso não conseguir converter a string para apenas números to tipo byte entra no loop ou número ser menor  igual a 21 ou superior a 80
            {
                Console.WriteLine("Um professor deve ter no mínimo 22 anos e no máximo 79");
                Console.WriteLine("Idade invalida por favor digitar novamente com um número inteiro\n");
                byte.TryParse(Console.ReadLine(), out Idade);

            }

          


        }
        public void CadastrarListaProfessor()
        {
            Console.WriteLine("Digite o número de professores que serão cadastrados na lista");
           while (!uint.TryParse(Console.ReadLine(), out NumeroProfessores))
            {
                Console.WriteLine("Número de professor incorreto, por favor digitar novamente");
                Console.WriteLine();
                uint.TryParse(Console.ReadLine(), out NumeroProfessores);
            }

           for (int i=0; i<NumeroProfessores; i++)
            {
                Professor professor = new Professor();
                Console.WriteLine($"Digite o nome do(a) {i + 1}° Professor(a)");
                professor.ColoqueAsInformacaosProfessor();
                ListaProfessor.Add(professor);
            }

        }


        public string MostrarProfessor() => $" O(a) Professor(a) {Nome} do sexo {Sexo} com a idade {Idade} foi registrado com o registro: {Registro} \n"; // Metodo para mostrar o que foi armazenados dentro das variaveis



    }
}