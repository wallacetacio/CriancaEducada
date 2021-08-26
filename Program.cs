using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            string CriancaEducada;
            string censura = "$#@%&*";
            Console.Write("Me diga o que você pensa sobre o aluno que não faz a tarefa: ");
            CriancaEducada = Console.ReadLine()
            .Replace("chato",censura)
            .Replace("chata",censura)
            .Replace("boboca",censura)
            .Replace("boba",censura)
            .Replace("feio",censura)
            .Replace("feia",censura)
            .Replace("bobo",censura)
            .Replace("bocó",censura)
            .Replace("tonto",censura)
            .Replace("tonta",censura)
            .Replace("palerma",censura)
            .Replace("paspalho",censura)
            .Replace("paspalha",censura)
            .Replace("tantã",censura)
            .Replace("panaca",censura)
            .Replace("pentelho",censura)
            .Replace("pentelha",censura)
            .Replace("burro",censura)
            .Replace("burra",censura)
            .Replace("besta",censura);
            Console.WriteLine("Eu sou uma criança educada. No seu lugar eu diria: {0} ", CriancaEducada);
        }
    }
}
