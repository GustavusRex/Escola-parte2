using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Menu
    {
        Turma turma = new Turma();
        Professor professor = new Professor();
        public void Menyu()
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Para Cadastro Escolar\n");
                Console.WriteLine("Digite 1 para cadastrar as turmas");
                Console.WriteLine("Digite 2 para cadastrar os alunos");
                Console.WriteLine("Digite 3 para cadastrar os professores");
                Console.WriteLine("Digite 4 para mostrar as turmas");
                Console.WriteLine("Digite 5 para mostrar os alunos");
                Console.WriteLine("Digite 6 para mostrar os professores");
                Console.WriteLine("Digite 0 para sair do cadastro\n");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Cadastrar turmas escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            turma.AlocarNumeroTurma();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\nCadastrar alunos escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            Console.WriteLine("Digite 0 para voltar ao menu");
                            turma.CadastrarAlunosTurma();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\nCadastrar professor escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            professor.CadastrarListaProfessor();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar alunos escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            foreach (uint turm in turma.Listaturma)

                                Console.WriteLine(turm.CodigoTurma)
                            break;
                        }

                    case 5:
                    
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar alunos escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            foreach (Aluno aluno in turma.ListaAlunos) 

                                Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                                                  $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Situacao}");
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar professor escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            foreach (Professor prof in professor.ListaProfessor)

                                Console.WriteLine($"Professores {prof.Nome} do sexo {prof.Sexo} com a idade {prof.Idade}, " +
                                                  $" com o número de registro {prof.Registro}\n");
                            break;

                        }



                }
                Console.WriteLine("Deseja volta ao menu? SUKIN SYN??????????????????????????????");
                opcao = int.Parse(Console.ReadLine());

            } while (opcao == 9 );
        }
    }
}
