using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma();
            Menu menu = new Menu();

            /* turma.AlocarNumeroTurma();

             Console.WriteLine("Cadastre um professor para turma\n");
             turma.CadastrarProfessor();

             Console.WriteLine("Cadastre uma turma com alunos");
             turma.CadastrarAlunosTurma();
             Console.Clear();
             Console.Write($"\nA turma número: { turma.NumeroTurma}, estão registrados: \n");*/

            menu.Menyu();
            Console.Clear();

           // foreach (Aluno aluno in turma.Alunos) // Foreach para percorrer o Objeto Aluno dentro da lista turma para mostrar as variaveis com seus dados armazenados
               
               // Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                             //     $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Situacao}");

            //Console.WriteLine($"\n A turma {turma.NumeroTurma} terá {turma.MostrarProfessorCadastrado()}");
            //Console.ReadLine(); */


            

        }
    }

}