using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expressao = "((3 + 11)) * (14 - 1)()";

        if (validarParenteses(expressao))
        {
            Console.WriteLine("A expressão matemática está balanceada.");
        }
        else
        {
            Console.WriteLine("A expressão matemática NÃO está balanceada.");
        }

        Console.ReadLine();
    }

    static bool validarParenteses(string expressao)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char c in expressao)
        {
            if (c == '(')
            {
                pilha.Push(c);
            }
            else if (c == ')')
            {
                if (pilha.Count == 0)
                {
                    return false; 
                }
                pilha.Pop();
            }
        }

        return pilha.Count == 0;
    }
}
