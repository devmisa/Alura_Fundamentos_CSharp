﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");


            // character 
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);


            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);


            string titulo = "Alura Cursos de tecnologia" + 2022;
            string cursosProgramacao = @" 
            - .NET 
            - Javascript";
                                
               
                        
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();

        }
    }
}
