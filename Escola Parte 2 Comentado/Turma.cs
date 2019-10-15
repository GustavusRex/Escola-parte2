using System;
using System.Collections.Generic;
using System.Text;
namespace Escola
{
    class Turma // Metodo onde Aluno e Professor são encapsulados 
    {
        
        Professor professor = new Professor();
        public List<uint> Listaturma = new List<uint>();
        public List<Aluno> ListaAlunos = new List<Aluno>();
        public ushort NumeroTurma = 0;
        uint NumeroAlunos = 0;
        public uint CodigoTurma;

        public void AlocarNumeroTurma()
        {
            Console.WriteLine("Digite a quantidade de turmas");
            
            while (!ushort.TryParse(Console.ReadLine(), out NumeroTurma) || NumeroTurma ==0)// Caso não conseguir converter a string para apenas números to tipo ushort entra no loop ou número ser igual a 0
            {
                Console.WriteLine("\nNúmero digitado invalido, porfavor digite um número inteiro\n");
                ushort.TryParse(Console.ReadLine(), out NumeroTurma);
                
            }
            for (int i = 0; i < NumeroTurma; i++) 
            {
                Turma turma = new Turma();
                Console.WriteLine("Digite o Codigo da turma");
                CodigoTurma = uint.Parse(Console.ReadLine());
                
                Listaturma.Add(CodigoTurma);
            }

        }

        public void CadastrarProfessor()
        {
            professor.ColoqueAsInformacaosProfessor();
        }

        public string MostrarProfessorCadastrado() => professor.MostrarProfessor();

        public void CadastrarAlunosTurma()
        {
            Console.WriteLine("\nDigite a quantidade de alunos para o cadastro");

            
            uint.TryParse(Console.ReadLine(), out NumeroAlunos);
            // TryParse para tentar convertar o que foi amarzenado na string em um tipo uint 
            while (NumeroAlunos == 0) // Caso não conseguir converter a string para apenas números do tipo uint entra no loop ou número  igual a 0
            {
                Console.WriteLine("Número de alunos incorreto, por favor digitar novamente");
                Console.WriteLine();
                uint.TryParse(Console.ReadLine(), out NumeroAlunos);
            }

            for (int i = 0; i < NumeroAlunos; i++) // for utilizado para repetir a quantidade que for registrado um aluno
            {
                Aluno aluno = new Aluno();

                aluno.ColoqueAsInformacaosAlunos(); // armazenado os dados digitados dentro das variaveis 
                ListaAlunos.Add(aluno); // adicionando as variaveis com dados dentro da lista
            }

        }
    }
}
