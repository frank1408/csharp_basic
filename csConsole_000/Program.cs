﻿using System;

namespace csConsole_000
{
    class MainClass
    {
        public static void Esperar_y_Limpiar()
        {
            //Console.ReadKey();
            Console.Clear();
        }

        public static void Cs001() {
            Console.WriteLine("Hello World!");
            int age = 24;
            decimal numeroPI = 3.141592m;
            string firstName = "Franklin";
            bool isTrue = false;

            Console.WriteLine("Your name is " + firstName);

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("El numero pi es " + numeroPI);
            Console.WriteLine("Are you working ?");
            Console.WriteLine(isTrue);
            Console.WriteLine("I am learning csharp");



        }

        public static void Cs002()
        {
            Console.WriteLine("Caracteres especiales");
            Console.WriteLine("\tHola\nQue tal ... ? ");
            Console.WriteLine("\tHola\nQu\"e\" tal ... ? ");
            Console.WriteLine("c:\\Users\\iam\\Desktop");
            Console.WriteLine(@"muchos

espacio  s entre    palabras");
            Console.WriteLine(@"c:\invoices");

            Console.WriteLine("sin muchos caracteres raros");

            Console.WriteLine("Unicode Escape Characters UTF-16");

            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);

            string greeting = "Hello";

            string message1 = greeting + " " + firstName + "!";
            string message2 = $"{greeting}   {firstName}!";

            Console.WriteLine(message1 + "\n" + message2);

        }

        public static void Cs003()
        {

            string name = "Franklin Rodriguez";

            string msg = $"Hello {name}!";

            Console.WriteLine(msg);

            string projectName = "First-Project";

            Console.WriteLine($@"C:\Output\{projectName}\Data");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine(russianMessage);

        }

        public static void Cs004() {
            //.
            int a = 8;
            int b = 1;

            int c = 9 + a + b;
            Console.WriteLine($"the result is {c}");

            c -= c + a - b;
            Console.WriteLine($"the result is {c}");

            c = 0;
            c = a * b * b * a * 9;
            Console.WriteLine($"the result is {c}");

            c = c / 9;
            Console.WriteLine($"the result is {c}");

            decimal accountA = 72.27m;
            decimal accountB = 18.81m;
            decimal accountC = accountA - accountB;
            accountC = accountA * accountB;
            Console.WriteLine(accountC);


            accountA = 81;
            accountB = 72;
            accountC++;

            if ( accountA % 2 == 0 )
            {
                Console.WriteLine($"accountA is divisible by 2, osea es par va.");
            }
            else if( accountA % 9 == 0)
            {
                Console.WriteLine($"accountA is divisible by 9");

            }
            else
            {
                Console.WriteLine("no is divisible by 2 or 9");
            }

            for (int i=0; i < accountA; i++ )
            {
                Console.Write($"{i} ");
            }


            // farengeih a celcius
            decimal tmpF = 94m;

            decimal tmpC = 0m;
            tmpC = (tmpF - 32) * (5m / 9m);

            Console.WriteLine(tmpC);



            //.
        }

        public static void Cs006() {
            //.
            Random randomm = new Random();
            int minValue = 0;
            int maxValue = 100;
            int x = randomm.Next(minValue, maxValue);
            Console.WriteLine(x);

            Console.WriteLine(100 / 2);

            Console.WriteLine(100m / 2m);

            Console.WriteLine(Math.Sqrt(81));
            
            //.
        }

        public static void Cs007()
        {

            Console.WriteLine($"La raiz de 81 es: {Math.Sqrt(81)}");

            int[] intCounts = new int[3];
            intCounts[0] = 3;
            intCounts[1] = 9;
            intCounts[2] = 6;

            Console.Write("\nEl array tiene: ");
            for(int i = 0; i < intCounts.Length; i++ )
            {
                //.
                Console.Write( intCounts[i] + " ");
            }


            string[] nombres = new string[3];
            nombres[0] = "Jeannie";
            nombres[1] = "Michelle";
            nombres[2] = "Barbara";

            Console.Write("\nEl array2 tiene: ");

            for ( int i = 0; i < nombres.Length; i++)
            {
                //.
                Console.Write(nombres[i] + " ");
            }

            int val1 = 9;
            int val2 = 18;

            Console.WriteLine(Math.Max(val1, val2));

            /*
             * if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total += 6;
}
            */

        }


        public static void Cs008()
        {
            //.
        }



        public static void Main(string[] args)
        {
            /*
             The worst that can happen is that you'll get a compilation error.
                                                        Microsoft.
             */


            // llamando la funcion necesario.
            Cs008();

        }
    }
}