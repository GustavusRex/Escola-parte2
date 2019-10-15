using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    abstract class Pessoa // Classe onde guarda apenas as caracteristicas de pessoa
    {
        public string Nome;
        public string Sexo;
        public byte Idade = 0;
        public bool SoLetras(string s) // Metodo para validação da string desejada
        {
            if ((string.IsNullOrEmpty(s)) || (s.StartsWith(" ") || (s.Length < 3))) // Retorná falso para uma string nula, com espaço ou menor que 3 caracteres para validar a string
                return false;

            foreach (char c in s) // o Foreach irá percorrer cada caracter da string 
            {
                if (!char.IsLetter(c)) // Se o caracter achar algo que não for uma letra retorna valor falso em caso de não acha a string passa
                    return false;
            }

            return true;
        }

    }
}
