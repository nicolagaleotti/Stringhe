﻿using System;
using EserciziStringhe;

namespace ConsoleProva
{
    class Program
    {
        static void Main(string[] args)
        {
            //prova AreEquals
            Console.WriteLine("prova AreEquals");
            Console.Write("stringa 1: ");
            string s1 = Console.ReadLine();
            Console.Write("stringa 2: ");
            string s2 = Console.ReadLine();
            bool risposta = Metodi.AreEquals(s1, s2);
            Console.WriteLine(risposta);
            //prova ContainsDoubleChar
            Console.WriteLine("prova ContainsDoubleChar");
            Console.Write("stringa: ");
            string stringa = Console.ReadLine();
            bool risposta2 = Metodi.ContainsDoubleChar(stringa);
            Console.WriteLine(risposta2);
            //prova Convert
            Console.WriteLine("prova Convert");
            Console.Write("stringa: ");
            string stringa1 = Console.ReadLine();
            string risposta3 = Metodi.Convert(stringa1);
            Console.WriteLine(risposta3);
        }
    }
}
