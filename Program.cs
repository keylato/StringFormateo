using System;
using System.Collections.Generic;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //"John" -> "john" convertir la mayuscula a la miniscula
            string valor1 = "John";
            //String valor2 = "john"
            string valor2 = valor1.ToLower();
            
             Console.WriteLine("\"{0}\" -> \"{1}\"",valor1,valor2);

             //practica6

              string value1 = "Hola";
            // Qué voy a buscar, Por qué lo voy a remplazar
            // Remplazar las "a" por un "4"
            string value2 = value1.Replace("a", "4");
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Hola Mundo";
            value2 = value1.Replace("o", "0");
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            
            Console.WriteLine("-----");

            value1 = "Hola Mundo";
            value2 = value1.Replace("Mundo", "Alumnos");
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "474+621";
            string[] value2array = value1.Split("+");
            Console.WriteLine(value1);
            // Se muestra como System.String[]
            // Console.WriteLine(value2array);

            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            value1 = "474+621+56+21+457";
            value2array = value1.Split("+");

            Console.WriteLine(value1);
            Console.WriteLine("El resultado del split tiene " + value2array.Length + " strings");
            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            value1 = "fresa mora frambuesa";
            value2array = value1.Split(" ");
            Console.WriteLine(value1);
            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            MostrarEjemploSplit("fresa mora frambuesa", "m");
            MostrarEjemploSplit("fresa  mora frambuesa", " ");
            MostrarEjemploSplit("fresa  mora frambuesa".Replace("  ", " "), " ");

            MostrarEjemploSplit("1 +4 + 6 +3+5 + 22", "+");
            // Replace(" ", "") -> Borrar espacios
            MostrarEjemploSplit("1 +4 + 6 +3+5 + 22".Replace(" ", ""), "+");

            MostrarEjemploSplit("fresa mora frambuesa", "mora");

            Console.WriteLine("-----");

            value1 = " fresa ";
            value2 = value1.Trim();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, jOHN";
            value2 = value1.ToLower();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, jOHN";
            value2 = value1.ToUpper();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, John";
            // value2 = value1.Reverse();
            // Convertir string a char[]
            char[] charArray = value1.ToCharArray();
            // Invertir (reverse) el array
            Array.Reverse( charArray );
            // Crear un nuevo string a partir del char[]
            value2 = new string( charArray );
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Hola Mundo!";
            string substring1 = value1.Substring(0, 4);
            string substring2 = value1.Substring(2, 4);
            string substring3 = value1.Substring(8, 3);
            Console.WriteLine(value1);
            Console.WriteLine(substring1);
            Console.WriteLine(substring2);
            Console.WriteLine(substring3);


            Console.WriteLine("-----");

             List<string> nombres = new List<string>();
            nombres.Add("Peter");
            nombres.Add("Albrt");
            nombres.Add("John");

            Console.WriteLine("Peter?" + nombres.Contains("Peter"));
            Console.WriteLine("Bert, Jo?" + nombres.Contains("Bert, Jo"));

            if (nombres.Contains("Peter"))
            {
                //hacer algo en caso de que si 
            }
            
            Console.WriteLine("-----");

            value1= "Peter, ALbert, John";
            Console.WriteLine("Peter?"+ value1.Contains("Peter"));
            Console.WriteLine("bert, Jo?"+ value1.Contains("bert, Jo"));
            Console.WriteLine("peter?"+ value1.ToLower().Contains("peter"));

            Console.WriteLine("-----");
            
            value1 = "Peter, Albert, John";
            //"Peter, Albert, John" -> "John, ALbert, Peter"
            //1) Separarr en palabras
            //2) Invertir orden de palabras
            value2array = value1.Split(", ");
            //value2Array.Reverse() no existe!
            Array.Reverse(value2array);
            foreach(string val in value2array)
            {
                Console.WriteLine(val);
            }
            



        }

        // public -> accesible desde cualquier archivo
        // static -> se puede mandar a llamar desde otro método static (en este caso, el Main)
        // void -> no devuelve nada (solamente imprime información en la consola)
        public static void MostrarEjemploSplit(string valor, string separador)
        {
            Console.WriteLine("-----");
            string[] valorArray = valor.Split(separador);
            Console.WriteLine(valor);
            Console.WriteLine("El resultado del split tiene " + valorArray.Length + " strings");
            foreach(string val in valorArray)
            {
                Console.WriteLine(val);
            }
            
            

           



            
            

        } 



    }
}
